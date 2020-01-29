#include <iostream>

#include <cstdint>
using namespace std;

int main() {
	int32_t num;
	uint64_t num2;
	int8_t num3;
	double pi = 3.14159265359;
	double doubleRadius = 15123.123;
	double area = pi * doubleRadius * doubleRadius;
	cout.precision(17);
	cout << fixed;
	cout << area<<endl;
	cin.get();
}