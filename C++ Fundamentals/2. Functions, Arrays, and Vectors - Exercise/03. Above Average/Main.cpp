#include <iostream>
#include<vector>
using namespace std;

int average(vector<int>& vec) {
	const size_t SIZE = vec.size();
	int sum = 0;
	for (size_t i = 0; i < SIZE; i++) {
		sum += vec[i];
	}
	return (sum/SIZE);
}

void elementsGreaterThanOrEqual(vector<int>& vec, int lim) {
	const size_t SIZE = vec.size();
	for (size_t i = 0; i < SIZE; i++) {
		int el = vec[i];
		if(el >= lim) {
			cout << el << " ";
		}
	}
	cout << endl;
}
int main() {
	size_t n;
	cin >> n;
	vector<int>vec(n);
	for (size_t i = 0; i < n; i++) {
		cin >> vec[i];
	}
	elementsGreaterThanOrEqual(vec, average(vec));
	return 0;
}