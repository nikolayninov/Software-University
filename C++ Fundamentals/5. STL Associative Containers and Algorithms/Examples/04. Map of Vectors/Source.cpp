#include<iostream>
#include<string>
#include<sstream>
#include<vector>
#include<map>

int main()
{
	using namespace std;
	/*
	4
	Tony 2 5 5 3 6
	George 2 2 3
	Kerrigan 6 6 2 6 2 6
	Jaina 6 6 5

	Then:
	George
	Kerrigan
	end
	*/

	map<string, vector<int>> studentGrades;

	int numStudents;
	cout << "Enter students count: ";
	cin >> numStudents;


	cin.ignore();
	for (int i = 0; i < numStudents; ++i)
	{
		string line;
		getline(cin, line);

		istringstream lineIn(line);
		string name;
		lineIn >> name;

		vector<int>grades;
		int grade;
		while (lineIn >> grade)
		{
			grades.emplace_back(grade);
		}
		studentGrades[name] = grades;
	}

	string command;
	getline(cin, command);
	while (command != "end")
	{
		cout << endl;
		map<string, vector<int>>::iterator gradesIt = studentGrades.find(command);
		if (gradesIt != studentGrades.end())
		{
			for (int grade : gradesIt->second)
			{
				cout << grade << " ";
			}
		}
		else
		{
			cout << "no info";
		}
		getline(cin, command);
	}
	cout << endl;
	system("pause");
}