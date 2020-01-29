#include<iostream>
#include<string>
#include<sstream>
using namespace std;

class Person {
	class Body {
	private:
		double heightMeters;
		double weightKgs;

	public:
		Body(double heightMeters, double weightKgs) :
			heightMeters(heightMeters),
			weightKgs(weightKgs) {
		}
		void increaseWeight(double kgs) {
			this->weightKgs += kgs;
		}
		string getInfo() {
			ostringstream info;
			info << "height: " << this->heightMeters
				<< ", weight: " << this->weightKgs;
			return info.str();
		}
	};
private:
	string name;
	int age = 0;
	Body body;

public:
	Person():
		body(0,0){
	}
	Person(string name, int age, double heightMeters, double weightKgs) :
		name(name),
		age(age),
		body(heightMeters, weightKgs) {
	}
	string getName() {
		return this->name;
	}
	void makeOlder(int years) {
		this->age += years;
	}
	string getInfo() {
		ostringstream info;
		info << "name: " << this->name
			<< ", age: " << this->age
			<< ", " << this->body.getInfo();
		return info.str();
	}
};

int main()
{
	Person person("Refe Ctored", 42, 1.82, 82.3);
	cout << person.getInfo() << endl;
	person.makeOlder(1);
	cout << person.getInfo() << endl;

	system("pause");
}