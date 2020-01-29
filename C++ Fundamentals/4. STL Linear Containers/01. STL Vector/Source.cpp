#include <iostream>
#include<sstream>
#include<string>
#include<vector>
#include<list>

int main() {
	using namespace std;

	vector<string>words{"Hello", ", ", "World"};

	for (vector<string>::iterator it = words.begin(); it != words.end(); ++it) {
		cout << *it << " has size: "<< it->size() <<endl;
	}

	system("pause");
}