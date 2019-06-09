using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SalesManTour
{
    /// <summary>
    /// Інтерфейс отримання розв'язку оптимізаційної задачі.
    /// Наприклад, задачі комівояжера генетичним алгоритмом.
    /// </summary>
    interface ISolver<T>
    {
        // Реалізація методу наближених обчислень, який можна перервати достроково,
        // і який вміє інформувати про хід обчислень. Метод можна запускати в окремому потоці.
        void Solve(CancellationToken token, IProgress<int> progress);

        // Поточне найкраще наближення до шуканого розв'язку < T == Tour > 
        T Best();
    }

    /// <summary>
    /// Розв'язування задачі комівояжера в одному обчислювальному потоці
    /// </summary>
    class SSolver: ISolver<Tour>
    {
        // Розмір популяції (найпристосованіших)
        private int popuSize;
        // Кількість простих мутацій
        private int mutCount;
        // Кількість мутацій напрямку
        private int rutCount;
        // Максимальна кільксть поколінь
        private int maxGener;
        // Усе потомство автоматично сортуватиметься за зростанням довжини туру
        private SortedDictionary<double, Tour> population;
        // Популяція найпристосованіших
        private KeyValuePair<double, Tour>[] topTours;
        // Генератор випадкових чисел потрібен для мутації турів
        private Random random;

        public SSolver(int populationSize, int mutationCount, int routeMutationCount, int maxGeneration)
        {
            popuSize = populationSize;
            mutCount = mutationCount;
            rutCount = routeMutationCount;
            maxGener = maxGeneration;
            population = new SortedDictionary<double, Tour>();
            topTours = new KeyValuePair<double, Tour>[populationSize];
            random = new Random();
        }

        // генерування початкової популяції - масиву випадкових перестановок номерів міст
        private void StartPopulation()
        {
            for (int i = 0; i < popuSize; ++i)
            {
                Tour t = new Tour(random);
                topTours[i] = new KeyValuePair<double, Tour>(t.Length(), t);
            }
        }

        // генерування нового покоління
        private void NextGeneration(CancellationToken token)
        {
            for (int i = 0; i < popuSize; ++i)
            {
                // процес тривалий, тому може бути перерваний кожної миті
                if (token.IsCancellationRequested) break;
                // Початкові члени популяції мають шанс продовжити існування в наступному поколінні
                Tour current = topTours[i].Value;
                population[topTours[i].Key] = current;
                // Кожен член популяції є джерелом для мутованих "нащадків":
                // для нього потрібно виконати задане число простих мутацій ...
                for (int k = 0; k < mutCount; ++k)
                {
                    Tour t = current.Mutate(random);
                    population[t.Length()] = t;
                }
                // ... і мутацій напрямку
                for (int k = 0; k < rutCount; ++k)
                {
                    Tour t = current.Rutate(random);
                    population[t.Length()] = t;
                }
            }
        }

        // Природній відбір
        private void Survive()
        {
            // Вибір найпристосованіших
            topTours = population.Take(popuSize).ToArray();
            // Відбракування всіх решта
            population.Clear();
        }

        public void Solve(CancellationToken token, IProgress<int> progress)
        {
            StartPopulation();
            int generation = 0;
            while (generation < maxGener && !token.IsCancellationRequested)
            {
                // Генерування наступного покоління в одному потоці
                NextGeneration(token);
                Survive();
                ++generation;
                if (generation % 50 == 0)
                {
                    progress.Report(generation);
                }
            }
        }

        public Tour Best()
        {
            return topTours[0].Value;
        }
    }

    /// <summary>
    /// Розв'язування задачі комівояжера в декількох паралельних обчислювальних потоках
    /// </summary>
    class PSolver : ISolver<Tour>
    {
        // Кількість потоків обчислень
        private int threadsCount;
        // Розмір популяції (найпристосованіших)
        private int popuSize;
        // Кількість простих мутацій
        private int mutCount;
        // Кількість мутацій напрямку
        private int rutCount;
        // Максимальна кільксть поколінь
        private int maxGener;
        // Усе потомство автоматично сортуватиметься(?) за зростанням довжини туру.
        // Мусимо використати безпечну щодо потоків колекцію.
        private ConcurrentDictionary<double, Tour> population;
        // Популяція найпристосованіших
        private KeyValuePair<double, Tour>[] topTours;
        // Генератори випадкових чисел потрібні для мутації турів.
        // Для кожного потоку виконання - ОКРЕМИЙ (!) генератор
        private Random[] random;

        public PSolver(int threadsCount, int populationSize, int mutationCount, int routeMutationCount, int maxGeneration)
        {
            this.threadsCount = threadsCount;
            popuSize = populationSize;
            mutCount = mutationCount;
            rutCount = routeMutationCount;
            maxGener = maxGeneration;
            population = new ConcurrentDictionary<double, Tour>();
            topTours = new KeyValuePair<double, Tour>[populationSize];
            random = new Random[this.threadsCount];
            for (int i = 0; i < this.threadsCount; ++i)
            {
                // Затримки потрібні, щоб усі генератори стартували з різних значень
                Thread.Sleep(5 + i);
                random[i] = new Random();
            }
        }

        // генерування початкової популяції - масиву випадкових перестановок номерів міст
        private void StartPopulation()
        {
            for (int i = 0; i < popuSize; ++i)
            {
                Tour t = new Tour(random[0]);
                topTours[i] = new KeyValuePair<double, Tour>(t.Length(), t);
            }
        }

        // генерування нового покоління для заданої частини популяції
        private void MakeGeneration(int first, int last, CancellationToken token, Random random)
        {
            for (int i = first; i < last; ++i)
            {
                // процес тривалий, тому може бути перерваний кожної миті
                if (token.IsCancellationRequested) break;
                // Початкові члени популяції мають шанс продовжити існування в наступному поколінні
                Tour current = topTours[i].Value;
                population[topTours[i].Key] = current;
                // Кожен член популяції є джерелом для мутованих "нащадків":
                // для нього потрібно виконати задане число простих мутацій ...
                for (int k = 0; k < mutCount; )
                {
                    Tour t = current.Mutate(random);
                    if (population.TryAdd(t.Length(), t)) ++k;
                }
                // ... і мутацій напрямку
                // вибраний спосіб додавання до словника гарантує потрібну кількість у обох випадках
                for (int k = 0; k < rutCount; )
                {
                    Tour t = current.Rutate(random);
                    if (population.TryAdd(t.Length(), t)) ++k;
                }
            }
        }

        // генерування наступного покоління поділено на декілька потоків
        private void NextGeneration(CancellationToken token)
        {
            // Кожному потокові - своє завдання!
            Task[] tasks = new Task[threadsCount];
            int[] bounds = new int[threadsCount + 1];
            // Усю популяцію поділимо на інтервали (по одному на потік)
            int step = topTours.Length / threadsCount;
            for (int i = 0; i < threadsCount; ++i)
            {
                bounds[i] = step * i;
            }
            bounds[threadsCount] = topTours.Length;
            // Створення завдань
            for (int i = 0; i < threadsCount; ++i)
            {
                int lowerLimit = bounds[i];
                int upperLimit = bounds[i + 1];
                Random rnd = random[i];
                // Кожному завданню для надійної роботи потрібен унікальний набір змінних
                tasks[i] = Task.Run(() => MakeGeneration(lowerLimit, upperLimit, token, rnd));
            }
            // Потрібна синхронізація
            Task.WhenAll(tasks).Wait();
        }

        // Природній відбір
        private int Survive()
        {
            // Безпечний словник не впорядкований, тому відбір найкращих дещо складніший
            topTours = population.OrderBy(pair => pair.Key).Take(popuSize).ToArray();
            population.Clear();
            return population.Count;
        }

        public void Solve(CancellationToken token, IProgress<int> progress)
        {
            StartPopulation();
            
            int generation = 0;
            while (generation < maxGener && !token.IsCancellationRequested)
            {
                NextGeneration(token);
                Survive();
                ++generation;
                if (generation % 50 == 0)
                {
                    progress.Report(generation);
                }
            }
        }

        public Tour Best()
        {
            return topTours[0].Value;
        }
    }
}
