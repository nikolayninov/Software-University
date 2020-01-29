#include<iostream>
using namespace std;

int main() {
	int n,loc;
	cin >> n;
	int min = INT_MAX;
	int max = INT_MIN;
	for (int i = 0; i < n; i++) {
		cin >> loc;

		if (min > loc) {
			min = loc;
		}
		if (max < loc) {
			max = loc;
		}
	}
	cout << min << " " << max << endl;
	return 0;
}