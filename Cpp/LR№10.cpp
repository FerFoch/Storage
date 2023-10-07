#include <fstream>
#include <iostream>
#include <windows.h>

/*10.3.Дан символьный(состоящий из символов) файл f.
а) Подсчитать число вхождений в файл сочетаний “ab”;
б) Определить входит ли в файл сочетание “abcdefgh”;
в) Подсчитать число вхождений в файл каждой из букв a, b, c, d, e, f и
вывести результат в виде таблицы :
a – Na	b – Nb	c – Nc
d – Nd	e – Ne	f – Nf	где Na, Nb, Nc, Nd, Ne, Nf - числа вхождений .*/

using namespace std;

int main()
{
    setlocale(LC_ALL, "RUS");
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    int a = 0, m = 0, k = 0, Na = 0, Nb = 0, Nc = 0, Nd = 0, Ne = 0, Nf = 0;
    string s1;
    ifstream file("f.txt");
    for (int i = 0; i < 1; ++i)
    {
        file >> s1;
        cout << s1 << endl;
    }
    file.close();
    for (int i = 0; i <= s1.size(); i++) // ab
    {
        if ((s1[i] == 'a') && (s1[i + 1] == 'b'))
        {
            m++;
        }
        if ((s1[i] == 'a') && (s1[i + 1] == 'b') && (s1[i + 2] == 'c') && (s1[i + 3] == 'd') && (s1[i + 4] == 'e') && (s1[i + 5] == 'f') && (s1[i + 6] == 'g') && (s1[i + 7] == 'h'))
        {
            k++;
        }
        if (s1[i] == 'a')
        {
            Na++;
        }
        if (s1[i] == 'b')
        {
            Nb++;
        }
        if (s1[i] == 'c')
        {
            Nc++;
        }
        if (s1[i] == 'd')
        {
            Nd++;
        }
        if (s1[i] == 'e')
        {
            Ne++;
        }
        if (s1[i] == 'f')
        {
            Nf++;
        }
    }
    if (k > 0)
    {
        cout << "Число вхождений в файл сочетаний “abcdefgh” " << k << endl;
    }
    else
        cout << " Вхождений в файл сочетаний “abcdefgh”  не обнаружено " << endl;

    cout << "Число вхождений в файл сочетаний “ab” " << m << endl;
    cout << Na << " - " << "Na" << "  ";
    cout << Nb << " - " << "Nb" << "  ";
    cout << Nc << " - " << "Nc" << "  " << endl;
    cout << Nd << " - " << "Nd" << "  ";
    cout << Ne << " - " << "Ne" << "  ";
    cout << Nf << " - " << "Nf" << "  ";

}