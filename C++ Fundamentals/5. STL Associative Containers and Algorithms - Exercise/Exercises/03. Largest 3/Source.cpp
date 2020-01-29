	#include<iostream>
	#include<string>
	#include<sstream>
	#include<map>
	using namespace std;

	int main()
	{
		multimap<double, bool>nums;
		string line;
		getline(cin, line);
		istringstream istr(line);
		double num;
		while (istr >> num)
		{
			nums.insert(pair<double, bool>(num, true));
		}
		if (nums.size() <= 3)
		{
			for (auto it = --(nums.end());it!=nums.begin();--it)
			{
				cout << it->first << " ";
			}
			cout << nums.begin()->first << endl;
		}
		else
		{
			multimap<double, bool>::iterator it = --(nums.end());
			for (int i = 0; i < 3;i++) {
				cout << it->first << " ";
				--it;
			}
			cout << endl;
		}
		return 0;
	}