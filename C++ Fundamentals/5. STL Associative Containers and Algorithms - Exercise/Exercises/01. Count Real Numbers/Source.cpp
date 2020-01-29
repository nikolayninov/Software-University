	#include<iostream>
	#include<sstream>
	#include<string>
	#include<map>

	using namespace std;

	int main()
	{
		map<double, int> numbers;
		string line;
		getline(cin, line);
		istringstream istr(line);
		double number;
		while (istr >> number)
		{
			numbers[number]++;
		}
		for (pair<double, int> n : numbers)
		{
			cout << n.first << " -> " << n.second << endl;
		}
		return 0;
	}