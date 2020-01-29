#include<iostream>
#include<string>
#include<sstream>
#include<vector>
using namespace std;

class Sentence {
private:
	vector<string> sentence;
public:
	Sentence(){}
	Sentence(string str) {
		istringstream istr(str);
		string word;
		while (istr >> word) {
			this->sentence.emplace_back(word);
		}
	}
	vector<string> getShiftedSentence(size_t n) {
		const size_t size = this->sentence.size();
		vector<string> shiftedSentence(size);
		for (size_t i = 0; i < size; ++i) {
			shiftedSentence[(i + n) % size] = this->sentence[i];
		}
		return shiftedSentence;
	}
};

int main()
{
	string line;
	getline(cin, line);
	Sentence sent(line);
	size_t n;
	cin >> n;
	vector<string> result = sent.getShiftedSentence(n);
	for (string s : result) {
		cout << s << endl;
	}
	system("pause");
}