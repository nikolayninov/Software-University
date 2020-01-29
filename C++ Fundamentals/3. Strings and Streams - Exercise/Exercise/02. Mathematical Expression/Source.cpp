#include<iostream>
#include<sstream>
#include<string>
using namespace std;

bool isValid(string& expr) {
	int leftBr = 0;
	int rightBr = 0;
	for (char ch : expr) {
		if (ch == '(')
			++leftBr;
		else if (ch == ')')
			++rightBr;
	}
	return leftBr == rightBr;
}

int main() {
	string input;
	getline(cin, input);
	cout << (isValid(input)?"correct":"incorrect") << endl;
	return 0;
}