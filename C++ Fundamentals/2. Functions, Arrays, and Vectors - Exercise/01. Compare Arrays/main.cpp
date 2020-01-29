#include <iostream>
#include<vector>
using namespace std;

bool areEqual(vector<int>& arr1, int length1, vector<int>& arr2, int length2) {
	if (length1 != length2)
		return false;
	for (int i = 0; i < length1; i++) {
		if (arr1[i] != arr2[i])
			return false;
	}
	return true;
}

int main() {
	int a;
	cin >> a;
	vector<int> arr1(a);
	for (int i = 0; i < a; i++) {
		cin >> arr1[i];
	}
	int b;
	cin >> b;
	vector<int> arr2(b);
	for (int i = 0; i < b; i++) {
		cin >> arr2[i];
	}
	
	cout << (areEqual(arr1, a, arr2, b) ? "equal" : "not equal") << endl;
	return 0;
}