#include<iostream>
#include<stack>
#include<queue>
using namespace std;

int main() {
	stack<int>s;
	s.push(42);
	s.push(13);
	s.push(69);
	while (!s.empty()) {
		cout << s.top() << " ";
		s.pop();
	}
	cout <<endl << "-----------" << endl;
	
	queue<int>q;
	q.push(42);
	q.push(13);
	q.push(69);
	while (!q.empty()) {
		cout << q.front() << " ";
		q.pop();
	}
	cout << endl << "-----------" << endl;

	system("pause");
}