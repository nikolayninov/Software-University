#include<iostream>
#include<vector>
#include<cmath>

std::vector<int>& generateRoots(int toNumber) {
	std::vector<int> roots; // making the variable static 
							// solves the problem
	for (int i = 0; i < toNumber; ++i) {
		roots.push_back(sqrt(i));
	}
	return roots;
}

int main() {
	std::vector<int>& rootsRef = generateRoots(100);

	std::vector<int> otherVector{ 42,13,69 };
	std::cout << rootsRef[4] << std::endl;
	std::cout << &rootsRef<<std::endl;
	system("pause");
}