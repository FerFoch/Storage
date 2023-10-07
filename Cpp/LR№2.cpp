#include <iostream>
#include <math.h>
#include <windows.h>

using namespace std;
/* Существует две фазы сна быстрый и медленный.сначала наступает медленный сон tm.Быстрый tb.человек разбуженный
 в быструю фазу чувствует себя бодрее, чем в медленную. 
 Определить состояние человека, если он лег спать в h1 часов m1 минут, и был разбужен в h2 часов m2 минут. */

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int tm = 80, tb = 10, h1;
	int m1, h2, m2, x5, x6;
	cout << "vedite chasi kogda ycnyl" << endl;
	cin >> h1;
	cout << "vedite minyt kogda ycnyl" << endl;
	cin >> m1;
	cout << "vedite chasi kogda procnyl" << endl;
	cin >> h2;
	cout << "vedite minyt kogda procnyl" << endl;
	cin >> m2;
	h1 = h1 * 60;
	h2 = h2 * 60;

	if (h1 < h2)
	{
		x5 = (h2 + m2 - h1 + m1);
		cout << x5 << endl;
	}
	else
	{
		x5 = (24 * 60) - (h1 + m1 - h2 + m2);
		cout << x5 << endl;
	}
	if (x6 % (tm + tb) >= 1 && x6 % (tm + tb) <= 80)
	{
		cout << "Medlennaya faza sna" << endl;
	}
	if (x6 % (tm + tb) >= 81 && x6 % (tm + tb) <= 89)
	{
		cout << "Bistraya faza sna" << endl;
	}
	if (x6 % (tm + tb) == 0)
	{
		cout << "Bistraya faza sna" << endl;
	}
	return 0;
}
