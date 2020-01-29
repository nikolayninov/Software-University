#include <iostream>
#include<vector>
using namespace std;

void printMFN(vector<int>& v) {
	vector<int>freqs(10);
	int maxFreq = 0;
	for (int n : v) {
		freqs[n]++;
	}
	for (int f : freqs) {
		if (f > maxFreq)
			maxFreq = f;
	}
	for (size_t i = 0; i < 10; i++) {
		if (freqs[i] == maxFreq) {
			cout<<i<<" ";
		}
	}
	cout << endl;
}

int main() {
	size_t n;
	cin >> n;
	vector<int>v(n);
	for (size_t i = 0; i < n; i++) {
		cin >> v[i];
	}
	printMFN(v);
	return 0;
}