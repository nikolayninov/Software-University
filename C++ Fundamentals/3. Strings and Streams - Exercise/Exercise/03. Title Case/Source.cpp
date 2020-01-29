#include<iostream>
#include<sstream>
#include<string>
using namespace std;

void titleCase(string& str) {
	const int SIZE = str.size();
	str[0] = toupper(str[0]);
	for (int i = 2; i < SIZE; i++) {
		if (!isalpha(str[i - 1]) && islower(str[i]))
			str[i]-=32;
	}
	
}

int main() {
	string input;
	getline(cin, input);
	titleCase(input);
	cout << input << endl;

	return 0;
}