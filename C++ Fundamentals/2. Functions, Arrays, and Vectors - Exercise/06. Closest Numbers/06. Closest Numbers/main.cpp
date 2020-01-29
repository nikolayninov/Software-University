#include<iostream>
#include<vector>
#include<cmath>
using namespace std;

long long minDistance(vector<int>& v) {
	const size_t SIZE = v.size();
	long long minDistance = INT64_MAX;
	if (SIZE == 1) {
		return 0;
	}
	for (size_t i = 0; i < SIZE-1; i++) {
		for (size_t j = i + 1; j < SIZE; j++) {
			long long dist = abs(v[i] - v[j]);
			if (dist <= 1) {
				return dist;
			}
			if (dist < minDistance) {
				minDistance = dist;
			}
		}
	}
	return minDistance;
}
int main() {
	size_t n;
	cin >> n;
	vector<int>v(n);
	for (size_t i = 0; i < n; i++) {
		cin >> v[i];
	}
	cout << minDistance(v) << endl;
}