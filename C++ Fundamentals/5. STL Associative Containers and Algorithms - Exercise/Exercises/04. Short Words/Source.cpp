#include<iostream>
#include<string>
#include<sstream>
#include<set>

using namespace std;

void tolower(string& str)
{
	for (char& ch : str)
	{
		ch = tolower(ch);
	}
}

int main()
{
	set<string>shortWords;
	string line;
	getline(cin, line);
	istringstream istr(line);
	string word;
	while (istr >> word)
	{
		if (word.size() < 5)
		{
			tolower(word);
			shortWords.emplace(word);
		}
	}
	set<string>::iterator it = shortWords.begin();
	cout << *it++;
	for (; it != shortWords.end(); ++it)
	{
		cout << ", " << *it;
	}
	cout << endl;
	system("pause");
}