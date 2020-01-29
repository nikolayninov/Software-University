#include<iostream>
using namespace std;

enum planets
{
	earth = 3,
	mars,
	jupiter,
	saturn,
	uranus,
	neptune
};

enum class Planets
{
	earth = 3,
	mars,
	jupiter,
	saturn,
	uranus,
	neptune
};

enum class PlanetsChar
{
	earth = 'e',
	mars='m',
	jupiter='j',
	saturn='s',
	uranus='u',
	neptune='n'
};
int main()
{
	cout << "earth (" << earth << ") is "
		<< uranus - earth << " planets away from "
		<< "uranus (" << uranus << ")" << endl;	

	Planets planetEarth = Planets::earth;

	//This one throws an error
	//Planets planetEarthInvalid = 3 ; 

	PlanetsChar planetEarthChar = PlanetsChar::earth;

	cout << (char)planetEarthChar << endl;
	system("pause");
}