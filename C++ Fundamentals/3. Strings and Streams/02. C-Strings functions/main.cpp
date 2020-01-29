#include<iostream>
using namespace std;
#include<cstring>
#pragma warning(disable : 4996)
int main() {
	char line1[50] = { 'h','e','l','l','o',',',' ','\0' };
	char line2[] = { 'w','o','r','l','d','!','\0' };

	cout << "size of line1: " << strlen(line1) << endl;
	cout << "size of line2: " << strlen(line2) << endl;

	strcat(line1, line2);
	cout << line1 << endl;

	const int index = strstr(line1, "world!") - line1;
	cout << "world found at index: " << index << endl;

	system("pause");
}