#include<iostream>
#include<unordered_map>
#include<vector>
#include<string>
using namespace std;


int main()
{
	unordered_map<string, short> miners;
	vector<string>m;

	string command;
	short quantity;	
	while (cin >> command && command != "stop")
	{
		cin >> quantity;
		if (miners[command]==0) {
			m.emplace_back(command);
		}
		miners[command] += quantity;
	}
	for (auto const& miner : m)
	{
		cout << miner << " -> " << miners[miner] << endl;
	}
	return 0;
}