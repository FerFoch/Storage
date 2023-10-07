#include <math.h> 
#include <iostream> 
#include <windows.h> 
#include <string>

using namespace std;
/* Дано натуральное число N.Выяснить, имеются ли среди чисел N, N + 1, … M близнецы, т.е.простые числа, разность между которыми равна двум.
Определить функцию, позволяющую распознать простые числа.Замечание.Использовать механизм формальных параметров. */

int bliznecy(int n)
{
    if (n == 1 || n == 0)
        return 0;
    for (int i = 2; i <= sqrt((double)n); i++)
    {
        if (n % i == 0)
            return 0;
    }
    return 1;
}

int main(int n, int fl, int m)
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    fl = 0;
    string str;
    do {
        cout << "Введите N: "; getline(cin, str);
        const char* N = str.c_str();
        n = atoi(N);
    } while (n <= 0);

    string str1;
    do {
        cout << "Введите M: "; getline(cin, str1);
        const char* M = str1.c_str();
        m = atoi(M);
    } while (m <= 0 || m < n);

    for (int i = n; i < m; i++)
    {
        for (int j = n + 1; j <= m; j++)
        {
            if (bliznecy(i) == 1 && bliznecy(j) == 1 && abs(i - j) == 2)
            {
                fl = 1;
                cout << "Числа близнецы : " << i << "  " << j << endl;
            }
        }
    }
    if (fl == 0)
        cout << "Чисел близнецов нет";
    return 0;
}