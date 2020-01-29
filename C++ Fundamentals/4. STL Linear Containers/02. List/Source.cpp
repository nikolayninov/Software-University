#include <iostream>
#include<list>
using namespace std;

int main() {
	list<int> numbers{ 1,3,5 };

	list<int>::iterator lastItemIter = numbers.end();
	lastItemIter--;
	numbers.insert(lastItemIter, 4);

	numbers.push_back(6);

	list<int>::iterator secondItemIter = numbers.begin();
	secondItemIter++;
	numbers.insert(secondItemIter, 2);

	numbers.insert(numbers.begin(), 0);
	for (int number : numbers) {
		cout << number << " ";
	}
	cout << endl;
	system("pause");
}