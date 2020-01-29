#include<iostream>
#include<sstream>
#include<string>
using namespace std;

int extractNumber(string& str) {
	string number = "";
	for (char ch : str) {
		if (isdigit(ch)) {
			number += ch;
		}
	}
	if (number == "") {
		return 0;
	}
	return stoi(number);
}

int main() {
	string input;
	getline(cin, input);
	istringstream istr(input);
	int max = INT_MIN;
	string noise;
	while (istr >> noise) {
		int num = extractNumber(noise);
		if (num > max) {
			max = num;
		}
	}
	cout << max << endl;
	return 0;
}