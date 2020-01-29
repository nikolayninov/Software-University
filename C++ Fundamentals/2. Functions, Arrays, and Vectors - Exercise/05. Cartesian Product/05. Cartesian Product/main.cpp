#include<iostream>
#include<vector>
using namespace std;

vector<int> cartesian(vector<int> &v) {
	const size_t SIZE = v.size();
	vector<int>cart(SIZE*SIZE);
	for (size_t i = 0; i < SIZE; i++) {
		for (size_t j = 0; j < SIZE; j++) {
			cart[i*SIZE + j] = v[i] * v[j];
		}
	}
	return cart;
}
void print(vector<int> v) {
	for (auto t : v) {
		cout << t << " ";
	}
	cout << endl;
}

int main() {
	static size_t n;
	cin >> n;
	vector<int>v(n);
	for (size_t i = 0; i < n; i++) {
		cin >> v[i];
	}
	print(cartesian(v));
	return 0;
}