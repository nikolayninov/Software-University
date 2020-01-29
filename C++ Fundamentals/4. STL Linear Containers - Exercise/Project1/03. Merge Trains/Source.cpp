#include<iostream>
#include<string>
#include<sstream>
#include<stack>
#include<queue>
using namespace std;

void fillQueue(queue<int>& q,istringstream& istr) 
{
	int n;
	while (istr >> n) {
		q.push(n);
	}
}

int main() 
{
	stack<char>lines;
	queue<int>railcars;

	queue<int>a;
	queue<int>b;

	string aLine;
	getline(cin, aLine);
	string bLine;
	getline(cin, bLine);

	istringstream aIstr(aLine);
	istringstream bIstr(bLine);
	fillQueue(a,aIstr);
	fillQueue(b,bIstr);
	
	while (!( a.empty() && b.empty() )) {
		if (a.empty()) {
			lines.push('B');
			railcars.push(b.front());
			b.pop();
			continue;
		}
		else if (b.empty()) {
			lines.push('A');
			railcars.push(a.front());
			a.pop();
			continue;
		}
		if (a.front() > b.front()) {
			lines.push('A');
			railcars.push(a.front());
			a.pop();
		}
		else {
			lines.push('B');
			railcars.push(b.front());
			b.pop();
		}
	}
	while (!lines.empty()) {
		cout << lines.top();
		lines.pop();
	}
	cout << endl;
	while (!railcars.empty()) {
		cout << railcars.front()<<" ";
		railcars.pop();
	}
	cout << endl;
	return 0;
}