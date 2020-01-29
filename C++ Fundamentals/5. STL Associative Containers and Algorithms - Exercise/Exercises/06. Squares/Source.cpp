#include<iostream>
#include<sstream>
#include<vector>
#include<algorithm>
#include<cmath>
using namespace std;

bool isSquare(int& n)
{
	if (n < 0)
		return false;
	int root = round(sqrt(n));
	return n==root*root;
}

int main()
{
	vector<int> squares;
	string line;
	getline(cin, line);
	istringstream istr(line);
	int n;
	while (istr >> n)
	{
		if (isSquare(n))
		{
			squares.push_back(n);
		}
	}
	std::sort(squares.begin(), squares.end(), greater<int>());
	for (const int& n : squares)
	{
		cout << n << " ";
	}
	cout << endl;
	system("pause");
}