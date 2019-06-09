using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManTour
{
    /// <summary>
    /// Клас інкапсулює послідовність відвідання міст, координати яких задано зовні.
    /// Має методи "мутування" для створення нових турів, вміє обчислити довжину маршруту.
    /// Потребує допомоги зовнішнього генератора випадкових чисел.
    /// </summary>
    class Tour
    {
        // Посилання на карту - колекцію кординат міст
        static public Point[] towns;
        // Перестановка номерів міст - послідовність відвідання
        private int[] order;

        // За замовчуванням міста відвідують послідовно від першого до останнього
        public Tour()
        {
            order = Enumerable.Range(0, towns.Length).ToArray();
        }
        // Випадкова перестановка послідовності міст
        public Tour(Random random)
        {
            order = Enumerable.Range(0, towns.Length).ToArray();
            random.Shuffle(order);
        }
        // Визначена перестановка послідовності міст
        public Tour(int[] nums)
        {
            order = nums;
        }

        // Довжина маршруту - сума довжин прямолінійних відрізків між сусідніми містами маршруту.
        // Довжина відрізку - відстань між точками на координатній площині.
        public double Length()
        {
            int n = towns.Length - 1;
            double L = Math.Sqrt(Math.Pow(towns[order[n]].X - towns[order[0]].X, 2) + 
                Math.Pow(towns[order[n]].Y - towns[order[0]].Y, 2));
            for (int i = 0; i < n; ++i)
                L += Math.Sqrt(Math.Pow(towns[order[i]].X - towns[order[i + 1]].X, 2) + 
                    Math.Pow(towns[order[i]].Y - towns[order[i + 1]].Y, 2));
            return L;
        }

        // Проста мутація: обмін місцями двох випадкових міст у послідовності
        public Tour Mutate(Random random)
        {
            int[] nums = (int[])this.order.Clone();
            int k = random.Next(order.Length);
            int l = random.Next(order.Length);
            int val = nums[k];
            nums[k] = nums[l];
            nums[l] = val;
            return new Tour(nums);
        }

        // Мутація напрямку: змінює на протилежний напрям руху між двома випадковими містами
        public Tour Rutate(Random random)
        {
            int[] nums = (int[])this.order.Clone();
            int n = order.Length;
            int k = random.Next(n);
            int l = random.Next(n);
            if (k == l) return new Tour();
            int val = 0;
            if (k < l)
                while (k < l)
                {
                    val = nums[k];
                    nums[k] = nums[l];
                    nums[l] = val;
                    ++k; --l;
                }
            else
                while (k > l)
                {
                    val = nums[k];
                    nums[k] = nums[l];
                    nums[l] = val;
                    ++k; k %= n;
                    --l; l = (l < 0) ? n - 1 : l;
                }
            return new Tour(nums);
        }

        public Point[] Route()
        {
            int n = order.Length;
            Point[] R = new Point[n + 1];
            for (int i = 0; i < n; ++i)
                R[i] = towns[order[i]];
            R[n] = towns[order[0]];
            return R;
        }
    }

    // Підказка з інтернету, що розширює можливості генератора випадкових чисел:
    //  випадкове перемішування послідовності (масиву) довільних об'єктів
    static class RandomExtensions
    {
        public static void Shuffle<T>(this Random rng, T[] array)
        {
            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }
    }
}
