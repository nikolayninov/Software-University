#include<iostream>
#include<vector>
using namespace std;

int main() {
	vector<double> squareRoots;
	for (int i = 0; i < 100; i++) {
		squareRoots.push_back(sqrt(i));
	}
	vector<char> letters{ 'x','y','z' };
	cout << letters[1] << endl;
	cin.get();
}