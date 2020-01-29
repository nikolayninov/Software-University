#include <iostream>
using namespace std;

int main() {
	double pi = 3.14159265359;
	double doubleRadius = 15123.123;
	double area = pi * doubleRadius * doubleRadius;
	cout.precision(17);
	cout << area;
	cin.get();
}