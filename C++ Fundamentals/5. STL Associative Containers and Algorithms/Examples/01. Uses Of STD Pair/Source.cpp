#include <iostream>
#include<string>
#include<utility>

int main() {
	using namespace std;

	pair<string, string> contact("Nini", "guess-what@gmail.com");

	cout << contact.first << ", email: " << contact.second << endl;

	contact.first = "Nikolay Ninov";
	contact.second = "guess-again-what@gmail.com";

	cout << contact.first << ", email: " << contact.second << endl;

	system("pause");
}