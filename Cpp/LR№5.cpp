#include <iostream>
#include <string>
#include <windows.h>
#include <conio.h>
using namespace std;
/*Проверить сбалансированность скобок в выражении. Скобки сбалансированы, если закрывающая скобка расположена после соответствующей открывающей,
и количество открывающих скобок совпадает с количеством закрывающих скобок. Не сбалансированные скобки - {(][)}. {([])}
                                                  {}        []         ()
*/
int main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    int a = 0, b = 0, kro = 0, fo = 0, ko = 0, krz = 0, kz = 0, fz = 0;
    char c;
    char* s;
    string s1;
    do
    {
        cout << " Введите предложение :" << " " << endl;
        getline(cin, s1);
    } while (s1.empty());

    s = new char[s1.size() + 1];
    for (int i = 0; i <= s1.size(); i++)
    {
        s[i] = s1[i];
        if ((s[i] == '('))
        {
            kro = i;
            b++;
            a++;
            cout << " Открывающие скобки" << " " << " kro  " << kro << endl;
        }
        if ((s[i] == '{'))
        {
            fo = i;
            b++;
            a++;
            cout << " Открывающие скобки" << " " << " fo   " << fo << endl;
        }
        if ((s[i] == '['))
        {
            ko = i;
            b++;
            a++;
            cout << " Открывающие скобки" << " " << " ko   " << ko << endl;
        }
        if ((s[i] == ')'))
        {
            krz = i;
            c = s[i];
            b++;
            a--;
            cout << " Закрывающие скобки" << " " << " krz  " << krz << endl;
        }
        if ((s[i] == '}'))
        {
            fz = i;
            c = s[i];
            b++;
            a--;
            cout << " Закрывающие скобки" << " " << " fz   " << fz << endl;
        }
        if ((s[i] == ']'))
        {
            kz = i;
            c = s[i];
            b++;
            a--;
            cout << " Закрывающие скобки" << " " << " kz   " << kz << endl;
        }
    }
    if (b == 0)
    {
        cout << " Скобки отсутствуют" << endl;
    }

    if (kro > krz || fo > fz || ko > kz)
    {
        cout << " Скобки НЕ сбалансированы" << endl;
        return 0;
    }

    s += '\0';
    cout << " Число скобок равно = " << a << endl;
    cout << " Число скобок равно = " << b << endl;

    if (a == 0)
        cout << " Скобки сбалансированы" << endl;
    else
        if (a < 0 || a > 0)
            cout << " Скобки НЕ сбалансированы" << endl;
    return 0;
}
