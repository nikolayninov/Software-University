#include<iostream>
#include<string>
#include<stack>
using namespace std;

bool checkBrackets(string& str) 
{
	stack<char>brackets;
	
	for (char ch : str) 
	{
		if (ch=='{'|| ch == '[' || ch == '(' ) {
			brackets.push(ch);
		}else if (ch == '}') {
			if (brackets.top() == '{') {
				brackets.pop();
			}
			else {
				return false;
			}
		}else if(ch == ']') {
			if (brackets.top() == '[') {
				brackets.pop();
			}
			else {
				return false;
			}
		}else if (ch == ')') {
			if (brackets.top() == '(') {
				brackets.pop();
			}
			else {
				return false;
			}
		}
	}
	
	return brackets.empty();
}

int main()
{
	string input;
	cin >> input;
	cout << (checkBrackets(input)?"valid":"invalid") << endl;
	return 0;
}