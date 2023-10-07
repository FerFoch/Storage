#include <iostream> 
#include <random>
#include <windows.h>
/*6.3.	Проверить, является ли заданная целочисленная квадратная матрица L(n,n) магическим квадратом, т.е. 
сумма элементов матрицы по строкам, по столбцам и по диагоналям одинакова. 
Для n>=4 предусмотреть заполнение массива случайными числами из диапазона –10 до 10.*/
using namespace std;
int main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    int n, b;
    cout << "Введите размерность массива: ";
    while ((!(std::cin >> n)) || (n <= 0))
    {
        cin.clear();
        while (cin.get() != '\n');
        cout << "Повторите ввод" << endl;
    }
    int** arr = new int* [n];

    for (int i = 0; i < n; i++)
    {
        arr[i] = new int[n];
    }
    if (n < 4)
    {
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
            {
                cout << "[" << i << "," << j << "] = ";
                cin >> arr[i][j];
            }

    }

    if (n >= 4)
    {
        srand(time(NULL));
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
            {
                arr[i][j] = rand() % 10 - 10;
            }

    }
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            cout << arr[i][j] << ' ';
        }
        cout << endl;

    }

    bool res = true;
    int sd1 = 0, sd2 = 0, s;
    for (int i = 0; i < n; i++)
    {
        sd1 += arr[i][i];
        sd2 += arr[i][n - i - 1];
    }
    if (sd1 != sd2)
        res = false;
    else
    {
        for (int i = 0; i < n; i++)
        {
            s = 0;
            for (int j = 0; j < n; j++)
                s += arr[i][j];
            if (s != sd1)
            {
                res = false;
                break;
            }
        }
        if (res)
            for (int j = 0; j < n; j++)
            {
                s = 0;
                for (int i = 0; i < n; i++)
                    s += arr[i][j];
                if (s != sd1)
                {
                    res = false;
                    break;
                }
            }
    }
    if (res)
        cout << "Да, это магический квадрат." << endl;
    else
        cout << "Нет, это не магический квадрат." << endl;
    system("pause");

    for (int i = 0; i < n; i++)
    {
        delete arr[i];
    }
    delete[] arr;
    return 0;
}