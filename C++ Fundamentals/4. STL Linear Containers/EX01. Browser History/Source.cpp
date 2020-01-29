#include<iostream>
#include<stack>
#include<queue>
#include<string>
using namespace std;
int main() {
	string input;
	stack<string> history;
	stack<string> forward;
	while (true) {
		getline(cin, input);
		if ("end" == input) 
		{
			break;
		}
		else if ("/back" == input) 
		{
			if (history.size() < 2) {
				cout << "No previous URLS\n";
				if (!history.empty()) {
					history.pop();
				}
			}
			else
			{
				forward.push(history.top());
				history.pop();
				cout << history.top() << '\n';
			}
		}
		else if ("/forward" == input)
		{
			if (forward.empty()) 
			{
				cout << "No next URLs\n";
			}
			else
			{
				cout << forward.top() << endl;
				history.push(forward.top());
				forward.pop();
			}
		}
		else //normal URL
		{
			forward = stack<string>();
			history.push(input);
		}
	}

	system("pause");
}