#include<iostream>
#include<vector>
using namespace std;

void print(vector<int>& numbers) {
	const size_t SIZE = numbers.size();
	for (size_t i = 0; i < SIZE; i++) {
		cout << numbers[i] << " ";
	}
	cout << endl;
}

void printMultiplied(vector<int> numbers, int multiplier) {
	const size_t SIZE = numbers.size();
	for (size_t i = 0; i < SIZE; i++) {
		numbers[i] *= multiplier;
	}
	print(numbers);
}

int main() {
	vector<int> numbers{ 1,2,3 };
	printMultiplied(numbers, 10);
	print(numbers);
	cin.get();
}