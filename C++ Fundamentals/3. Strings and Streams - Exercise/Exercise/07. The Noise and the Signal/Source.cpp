#include<iostream>
#include<sstream>
#include<string>
using namespace std;

string extractNumber(string& str) {
	string word = "";
	for (char ch : str) {
		if (!isdigit(ch)) {
			word += ch;
		}
	}
	
	return word;
}

int main() {
	string input;
	getline(cin, input);
	istringstream istr(input);
	string max = "";
	string noise;
	while (istr >> noise) {
		string word = extractNumber(noise);
		if (word.size() > max.size()) {
			max = word;
		}
		else if (word.size() == max.size() && word<max) {
			max = word;
		}
	}
	if (max == "") {
		cout << "no noise" << endl;
	}
	else {
		cout << max << endl;
	}
	return 0;
}