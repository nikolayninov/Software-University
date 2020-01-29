#include<iostream>
#include<sstream>
#include<vector>
#include<algorithm>

using namespace std;

int main()
{
	vector<double> nums;
	string line;
	getline(cin, line);
	istringstream istr(line);
	double n;
	while (istr >> n)
	{
		nums.push_back(n);
	}
	sort(nums.begin(), nums.end());
	vector<double>::iterator it = nums.begin();
	cout << *it++;
	for (; it != nums.end(); ++it)
	{
		cout << " <= " << *it;
	}
	cout << endl;
	system("pause");
}