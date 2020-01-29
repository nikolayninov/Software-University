#include<iomanip>
#include<iostream>
#include<cmath>
using namespace std;

class Point {
private:
	double x;
	double y;
public:
	Point(double x, double y) :
		x(x),
		y(y) {
	}
	double getX() {
		return this->x;
	}
	double getY() {
		return this->y;
	}
	double distanceTo(Point p) {
		return sqrt((p.getX() - x)*(p.getX() - x) + (p.getY() - y)*(p.getY() - y));
	}
};

int main() {
	double x, y;
	cin >> x >> y;
	Point p1(x, y);
	cin >> x >> y;
	cout << fixed << setprecision(3);
	cout << p1.distanceTo(Point(x, y)) << endl;
	system("pause");
}