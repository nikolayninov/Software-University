#define _USE_MATH_DEFINES
#include <cmath>
#include <iostream>
using namespace std;

int getMax(int, int);
void swap(int&, int&);
int main() {
	int x = 24;
	int y = 18;
	swap(x, y);
	cout << getMax(8.6, 7) << endl; // returns 8
	cout << x << endl;
	cin.get();
}

int getMax(int a, int b) {
	int maxValue;
	return ((a > b) ? a : b);
}

void swap(int& a, int& b) {
	int oldA = a; a = b; b = oldA;
}