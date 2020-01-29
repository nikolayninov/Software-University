#include <iostream>
#include<sstream>
#include<string>
#include<vector>
using namespace std;

void fillVec(vector<vector<int>>& vec, size_t size) {
	for (size_t i = 0; i < size; ++i) {
		string line;
		getline(cin, line);
		istringstream istr(line);
		int num;
		while (istr >> num) {
			vec[i].push_back(num);
		}
	}
}
void positionsOf(vector<vector<int>>& v, int n) {
	bool found = false;
	const size_t SIZE = v.size();
	for (size_t row = 0; row < SIZE; ++row) {
		const size_t rowSIZE = v[row].size();
		for (size_t col = 0; col < rowSIZE; ++col) {
			if (v[row][col] == n)
			{
				cout << row << " " << col << endl;
				found = true;
			}
		}
	}
	if (!found) {
		cout << "not found" << endl;
	}
}

int main() {
	size_t rows,cols;
	int n;
	cin >> rows>>cols; cin.ignore();
	vector<vector<int>> v(rows);
	fillVec(v,rows);
	cin >> n; cin.ignore();
	positionsOf(v, n);
	return 0;
}