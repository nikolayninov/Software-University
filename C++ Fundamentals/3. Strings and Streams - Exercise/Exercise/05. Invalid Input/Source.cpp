#include <iostream>
#include <string>
#include <sstream>
using namespace std;

int main() {
	ostringstream words;
	int sum = 0;

	string input;
	getline(cin, input);
	istringstream istr(input);

	string word="";	
	int number;
	while (istr>>word) {
		istringstream numIstr(word);
		if (numIstr >> number) {
			sum += number;
		}
		else {
			words << word<<" ";
		}
	}
	cout << sum << endl;
	cout << words.str() << endl;

	return 0;
}