#include<iostream>
#include<string>
using namespace std;

void replaceAll(string& str,string& toReplace, string& replacement) {
	const int SIZE = toReplace.size();
	int ind = str.find(toReplace);
	while (ind>=0) {
		str.replace(ind, SIZE, replacement);
		ind = str.find(toReplace);
	}
}

int main() {
	string input;
	string toReplace;
	string replacement;

	getline(cin, input);
	getline(cin, toReplace);
	getline(cin, replacement);

	replaceAll(input, toReplace, replacement);
	cout << input << endl;

	return 0;
}