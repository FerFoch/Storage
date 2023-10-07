#include <iostream>
#include <windows.h>
#include <string>
using namespace std;

/*8.3.	Дано целое n от 2 до 1000. Используя метод “решета Эратосфена”,
напечатать в возрастающем порядке все простые числа из диапазона n/2*n. */

int main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    int n;
    string str;
    do 
    {
        cout << "Введите N: "; 
        getline(cin, str);
        const char* N = str.c_str();
        n = atoi(N);
    } while (n <= 2 || n > 1000);

    int m = n / 2 * n;
    cout << "Диапазон равен = " << m << endl;
    int* array = new int[m];
    for (int i = 0; i < m; i++)
    {
        array[i] = i;
    }

    for (int i = 2; i < m; i++)
    {
        if (array[i] != 0)
            for (int j = i + 1; j < m; j++)
            {
                if (array[j] % array[i] == 0)
                    array[j] = 0;
            }
    }
    for (int i = 2; i < m; i++)
        if (array[i] != 0)
            cout << array[i] << endl;
    cin.get();
    return 0;
}