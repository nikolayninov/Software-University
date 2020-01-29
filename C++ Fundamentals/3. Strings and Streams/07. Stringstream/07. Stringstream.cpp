#include "pch.h"
#include <iostream>
#include<string>
#include<sstream>
using namespace std;

int main()
{
	string s = "hello world";
	istringstream stream(s);

	string hello, world;
	stream >> hello >> world;

	cout << hello << endl;
	cout << world << endl;

	string numbersString = "3.2 -2.3";
	istringstream numbersStream(numbersString);

	double num1, num2;
	numbersStream >> num1 >> num2;

	ostringstream outputStream;
	outputStream << "The sum is " << num1 + num2 << endl;
	cout << outputStream.str();

	s = "3 3 3";
	int number;

	istringstream istr(s);

	while (istr >> number) {
		cout << "Next item is: " << number << endl;
	}
	system("pause");
}