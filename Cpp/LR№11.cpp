#include <iostream>
#include <cmath>
#include <windows.h>
#include <string>

using namespace std;
//11.3.2.Определим операцию # так, что A#B = A - B + A mod B.Найти все числа из интервала от N до M, для которых эта операция коммутативна.

void main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    int  n, m, k, l, h, c = 0;
    cout << "Введите N: ";
    while ((!(cin >> n)) || (n <= 0))
    {
        cin.clear();
        while ((cin.get() != '\n') || n == ' ');
        cout << "Неверный ввод" << endl;
    }
    cout << "Введите M ";
    while ((!(cin >> m)) || (m <= 0))
    {
        cin.clear();
        while (cin.get() != '\n');
    }
    if (n > m)
    {
        int tmp = m;
        m = n;
        n = tmp;
    }
    k = m - n;
    for (int i = 0; i <= k; i++) 
    {
        l = n - m + (n % m);
        h = m - n + (m % n);
        
        if (l == h)
        {
            cout << "Двойки чисел " << n << "  " << m << endl;
            c++;
        }
        n++;
        m--;
        
    }
    if (c == 0)
    {
        cout << "Двойки чисел не найдены" << endl;
    }
}

