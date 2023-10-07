#include <iostream>
#include <cmath>
#include <windows.h>
#include <string>
/*Две строки нужно посимвольно сравнить по первой строке, строки с локом на кратность трем.
1. Если строки идентичны, то перевести обе строки из ДНК в РНК
2. Если есть различия, вывести количество различий.
3. Если строка хотя бы одна строка не делится на 3, вернуть пользователя к вводу.*/

using namespace std;


void main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    int x = 0, size = 0, e, k3 = 0, k, u = 0;
    string d, d1, d0 = "GCTA";

    cout << "Введите d: " << endl;
    do
    {
        cin >> d;
        e = 0;
        k3 = d.size() % 3;
        for (int i = 0; i < d.size(); i++)
        {
            for (int j = 0; j < d0.size(); j++)
            {
                if (d[i] == d0[j])
                {
                    e++;
                    break;
                }

            }

        }

        if (e != d.size() || (k3 != 0))
        {
            cout << "Повторите ввод" << endl;
        }

    } while (e != d.size() || (k3 != 0));

    cout << "Введите d1: " << endl;
    do
    {
        cin >> d1;
        e = 0;
        k3 = d1.size() % 3;
        for (int i = 0; i < d1.size(); i++)
        {
            for (int j = 0; j < d0.size(); j++)
            {
                if (d1[i] == d0[j])
                {
                    e++;
                    break;
                }

            }

        }

        if (e != d1.size() || (k3 != 0) || d1.size() != d.size())
        {
            cout << "Повторите ввод" << endl;
        }

    } while (e != d1.size() || (k3 != 0) || d1.size() != d.size());


    for (int i = 0; i < d.size(); i++) // х Считает расстояния Хэмминга, если оно есть
    {
        if (d[i] != d1[i])
        {
            x++;
        }

    }

    if (x == 0)
    {
        k = 0;
        for (int i = 0; i < d.size(); i++)
        {
            for (k; k < d.size(); k++)
            {
                if (d[k] == 'G')
                {
                    d[k] = 'C';
                    k++;
                    break;

                }
                if (d[k] == 'C')
                {
                    d[k] = 'G';
                    k++;
                    break;
                }
                if (d[k] == 'T')
                {
                    d[k] = 'A';
                    k++;
                    break;
                }
                if (d[k] == 'A')
                {
                    d[k] = 'U';
                    k++;
                    break;
                }
            }
        }

        cout << endl;
        cout << "Транскрипция РНК " << endl;
        cout << d << endl;
        cout << d << endl;
    }
    else
        cout << "Расстояние Хэмминга = " << x << endl;

}