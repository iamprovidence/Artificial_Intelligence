#include <iostream>
#include <conio.h>//consol input output, щоб мати змогу зчитати клавіші які нажимає користувач
#include <windows.h>//для функції sleep()
#include <ctime>//залежність часу для рандому

using namespace std;

int score, speed;
bool is_game_over;
const int width = 20;
const int height = 20;
int x, y, fruit_x, fruit_y;
int tail_x[100], tail_y[100], tail_length;
enum moving { stop = 0, left, right, up, down };
moving direction;

// повертає випадкове число із діапазону [min, max)
int random(int min, int max)
{
	srand(time(0));
	//формула rand() % (різниця між границями) + ліва границя
	return rand() % (max - min) + min;
}
//створює на карті фрукт
void spawn_fruit()
{
	fruit_x = random(1, height - 1);
	fruit_y = random(1, width - 1);
}
//встановити налаштування
void setUp()
{
	speed = 200;
	is_game_over = false;
	direction = stop;
	//змійка на початку гри посередині карти
	x = width / 2;
	y = height / 2;
	//фрукти появляються випадково
	spawn_fruit();
	score = 0;
	tail_length = 0;
}
//намалювати карту
void draw()
{
	system("cls");

	for (int i = 0; i < width; ++i)
	{
		for (int j = 0; j < height; ++j)
		{		
			if (i == 0 || j == 0 || i == width - 1 || j == height - 1)//карта
			{
				cout << '#';
			}
			else if (i == fruit_y && j == fruit_x)//фрукти
			{
				cout << 'F';
			}
			else if (i == y && j == x)//змійка
			{
				cout << '0';
			}
			else
			{
				bool print = false;
				for (int k = 0; k < tail_length; ++k)//хвіст
				{
					if(tail_x[k] == j && tail_y[k] == i)
					{
						print = true;
						cout << 'o';
					}
				}
				if (!print)
				{
					cout << ' ';
				}
			}	
		}
		cout << endl;
	}
	
	cout << "score: " << score << endl;
}
//отримувати данні від користувача
void input()
{
	if (_kbhit())//keyboard hit повертає true/false якщо нажата клавіша
	{
		char d;
		switch (d = _getch())//відстежує кнопку яку нажав користувач
		{
		case 'ф':case 'a': direction = moving::left; break;
		case 'ц':case 'w': direction = moving::up; break;
		case 'в':case 'd': direction = moving::right; break;
		case 'ы':case 'і':case 's': direction = moving::down; break;
		case 'й':case 'q': is_game_over = true ; break;
		}
	}
}
//логіка гри
void logic()
{
	//хвіст
	int prev_x = tail_x[0], prev_y = tail_y[0];
	int prev_2x, prev_2y;

	tail_x[0] = x;
	tail_y[0] = y;

	for (int i = 1; i < tail_length; ++i)
	{
		prev_2x = tail_x[i];
		prev_2y = tail_y[i];

		tail_x[i] = prev_x;
		tail_y[i] = prev_y;

		prev_x = prev_2x;
		prev_y = prev_2y;
	}

	//змінити напрямок руху змійки
	switch (direction)
	{
		case moving::left:--x; break;
		case moving::right:++x; break;
		case moving::up:--y; break;
		case moving::down:++y; break;
	}

	//швидкість змійки
	Sleep(speed);

	//якщо змійка вийшла за межі карти

	/*if (x >= width || x <= 0 || y <= 0 || y >= height)
	{
		is_game_over = true;
	}*/
	//змійка появляється із іншої сторони
	if (x == width - 1)
	{
		x = 1;
	}
	else if (x < 0)
	{
		x = width - 1;
	}
	if (y == height - 1)
	{
		y = 1;
	}
	else if (y < 0)
	{
		y = height - 1;
	}

	//якщо зїв хвіст
	for (int i = 0; i < tail_length; ++i)
	{
		if (tail_x[i] == x && tail_y[i] == y)
		{
			is_game_over = true;
		}
	}

	//якщо зїла фрукт 
	if (x == fruit_x && y == fruit_y)
	{
		++score;
		--speed;
		++tail_length;
		spawn_fruit();
	}
}

void main()
{
	setUp();

	while (!is_game_over)
	{
		input();
		logic();
		draw();
	}
}
