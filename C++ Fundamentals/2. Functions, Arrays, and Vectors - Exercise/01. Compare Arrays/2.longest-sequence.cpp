#include <iostream>
#include<vector>
using namespace std;

void logestSequence(vector<int> vec) {
	const size_t SIZE = vec.size();
	
	int seqLen = 1;
	int lastSeq = vec[0];
	
	int currSeqLen = 1;
	int currLastSeq = vec[0];

	for (size_t i = 1; i < SIZE; i++) {
		int el= vec[i];

		if (el == currLastSeq) {
		currSeqLen++;
		}
		else {
			if (currSeqLen >= seqLen) {
				seqLen = currSeqLen;
				lastSeq = currLastSeq;
			}
			currSeqLen = 1;
			currLastSeq = el;
		}
		if (currSeqLen >= seqLen) {
			seqLen = currSeqLen;
			lastSeq = currLastSeq;
		}
	}
	for (size_t i = 0; i < seqLen; i++) {
		cout << lastSeq << " ";
	}
	cout << endl;
}

int main() {
	size_t n;
	cin >> n;
	vector<int>vec(n);
	for (size_t i = 0; i < n; i++) {
		cin >> vec[i];
	}
	logestSequence(vec);
	return 0;
}