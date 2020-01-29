#include <iostream>
using namespace std;

double movingAverage(int nextNumber) {
	static int count = 0;
	static int sum = 0;
	sum += nextNumber;
	count++;
	return sum / (double)count;
}

int main(){
	cout << movingAverage(1) << endl;
	cout << movingAverage(2) << endl;
	cout << movingAverage(3) << endl;
	cout << movingAverage(4) << endl;
	cin.get();
}

