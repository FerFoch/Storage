#include <iostream>
#include <math.h>
#include <windows.h >

using namespace std;
/*1.3.Даны гипотенуза и катет прямоугольного треугольника.Найти второй катет,
площадь, периметр, и радиус вписанной и описанной окружностей.*/
int main()
{ 
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	double a, b, c, p, s, r1, r2;
	cout << "Введите а " << endl;
	cin >> a;
	cout << "Введите с " << endl;
	cin >> c;
	b = sqrt(c * c - a * a);
	cout << "Катет  = " << b << endl;
	s = (a * b) / 2;
	cout << "Площадь  = " << s << endl;
	p = a + b + c;
	cout << "Периметр = " << p << endl;
	r1 = (a * a + b * b) / 2;
	cout << "Радиус вписаной окружности = " << r1 << endl;
	r2 = (a + b - c) / 2;
	cout << "Радиус описаной окружности =  " << r2 << endl;
	return 0;
}