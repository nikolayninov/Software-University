#include <iostream>
#include<sstream>
#include<string>
#include<vector>
using namespace std;

void fillVec(vector<vector<int>>& vec,size_t size) {
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
bool vecEqualTo(vector<vector<int>>& vec1, vector<vector<int>>& vec2) {
	bool equal = true;
	const size_t SIZE = vec1.size();

	if (SIZE != vec2.size()){
		return false;
	}

	for (size_t row = 0; row < SIZE; ++row) {
		const size_t rowSIZE = vec1[row].size();
		if (rowSIZE != vec2[row].size()) {
			return 0;
		}
		for (size_t col = 0; col < rowSIZE; ++col) {
			if (vec1[row][col] != vec2[row][col])
				return 0;
		}
	}
}

int main() {
	size_t a;
	cin >> a; cin.ignore();
	vector<vector<int>> vec1(a);
	fillVec(vec1, a);

	size_t b;
	cin >> b; cin.ignore();
	vector<vector<int>> vec2(b);
	fillVec(vec2, b);

	cout << (vecEqualTo(vec1,vec2)?"equal":"not equal")<<endl;
	return 0;
}