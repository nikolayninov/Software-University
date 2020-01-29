#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/

void printSentence(vector<string>& alphabet, string sentence, int L) {
	int ind = 0;
	vector<string>res;
	for (string s : alphabet) {
		string row = "";
		for (char ch : sentence)
		{
			if (ch > 90) {
				ch -= 32;
			}
			if (ch < 65) {
				ch = 91;
			}
			ind = ch - 65;
			row += s.substr(L*ind, L);
		}
		res.push_back(row);
	}
	for (string row : res) {
		cout << row << endl;
	}
}

int main()
{
	int L;
	cin >> L; cin.ignore();
	int H;
	cin >> H; cin.ignore();
	vector<string>alphabet(H);
	string T;
	getline(cin, T);
	for (int i = 0; i < H; i++) {
		getline(cin, alphabet[i]);
	}
	printSentence(alphabet, T, L);

	system("pause");
}