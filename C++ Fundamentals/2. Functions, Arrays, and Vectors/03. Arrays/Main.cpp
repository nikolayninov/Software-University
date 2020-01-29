#include <iostream>
#include<cmath>
using namespace std;

int main() {
	double values[3] = { 0 }; // ALWAYS ADD A VALUE! This way the rest of the values are set to 0

	double vector2d[2] = { 0 };
	cin >> vector2d[0] >> vector2d[1];
	double length = sqrt(vector2d[0] * vector2d[0] + vector2d[1] * vector2d[1]);
	vector2d[0] /= length;
	vector2d[1] /= length;
	cout << vector2d[0] << " " << vector2d[1] << endl;
	system("pause");
}