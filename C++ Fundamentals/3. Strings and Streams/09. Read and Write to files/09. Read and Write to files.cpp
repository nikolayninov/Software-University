#include "pch.h"
#include <iostream>
#include<fstream>
using namespace std;
int main()
{
	ifstream input;
	input.open("input.txt");

	if (!input.is_open())
	{
		cerr << "input.txt file could not be found" << endl;
	}

	int a, b;
	input >> a >> b;

	ofstream output;
	output.open("output.txt", ofstream::app); // app-> append | out is by default
	output << a + b << endl;

	system("pause");
}