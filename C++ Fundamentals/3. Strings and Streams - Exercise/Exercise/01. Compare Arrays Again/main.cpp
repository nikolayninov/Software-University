#include<iostream>
#include<sstream>
#include<string>
using namespace std;

int main() {
	string input1;
	string input2;
	getline(cin, input1);
	getline(cin, input2);
	cout<<((input1==input2)?"equal":"not equal")<<endl;
	return 0;
}