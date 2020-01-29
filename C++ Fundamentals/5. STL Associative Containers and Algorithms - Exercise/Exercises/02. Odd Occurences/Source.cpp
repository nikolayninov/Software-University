#include<iostream>
#include<sstream>
#include<string>
#include<map>
#include<vector>
using namespace std;

void tolower(string& str) 
{
	for (char &ch : str)
	{
		ch=tolower(ch);
	}
}

int main()
{
	vector<string> names;
	map<string, int>occurences;
	string input;
	getline(cin, input);
	istringstream istr(input);
	string item;
	while (istr >> item)
	{
		tolower(item);
		if (occurences[item] == 0)
			names.push_back(item);
		occurences[item]++;
		

	}
	bool first = true;
	for (string i : names)
	{
		if (occurences[i] % 2 == 1)
		{
			if (first) {
				cout << i;
				first = false;
			}
			else
				cout << ", " << i;
		}
	}
	cout << endl;
	return 0;
}