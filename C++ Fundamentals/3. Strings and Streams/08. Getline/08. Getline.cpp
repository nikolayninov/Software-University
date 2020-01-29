#include "pch.h"
#include <iostream>
#include<string>
#include<sstream>
using namespace std;
int main()
{
	int numbersCount = 0;
	string input;

	getline(cin, input);
	numbersCount = stoi(input);

	getline(cin, input);

	istringstream istr(input);

	float number = 0.0f;
	while(istr >> number) 
		cout << number << endl;
	}
	

	system("pause");
}
