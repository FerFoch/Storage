#include <iostream>
#include <math.h>
using namespace std;

//По заданной формуле члена ряда с номером k составить две программы :
//а) программу вычисления суммы первых n членов заданного ряда;
//б) программу вычисления всех членов ряда, по модулю не меньших заданного числа E.
// k/((k+1)^2 + 3)
int main()
{
    int n;
    double k = 1.0, Sa = 1.0, Sb = 1.0, E, S;
    cout << "n  ="; cin >> n;
    cout << "E  ="; cin >> E;

    for (k = 1; k <= n; k++)
    {
        Sa += k / ((k + 1) * (k + 1) + 3);
    }

    for (k = 1;; k++)
    {
        S = k / ((k + 1) * (k + 1) + 3);
        if (S < E)
            break;
        else
            cout << S << endl;
    }
    cout << "Sa =" << Sa << "\n";
    system("pause");
    return 0;
}
