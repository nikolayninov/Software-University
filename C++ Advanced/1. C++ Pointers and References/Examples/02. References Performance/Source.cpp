#include<iostream>
#include<vector>

void printZeroIndices(const std::vector<int>& numbers) {
	const size_t size = numbers.size();
	for (size_t i = 0; i < size; ++i) {
		if (0==numbers[i]) {
			std::cout << i << " ";
		}
	}
	std::cout << std::endl;
}

int main() {
	using namespace std;

	vector<int> numbers{ 1,0,-2,7,0,10,-100,42 };
	printZeroIndices(numbers);
	system("pause");
}