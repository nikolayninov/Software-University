#include<iomanip>
#include<iostream>
#include<string>
#include<sstream>
#include<map>
using namespace std;

class Sale {
private:
	string town;
	string product;
	double price;
	double quantity;
public:
	Sale(){}
	Sale(string town, string product, double price, double quantity) :
		town(town),
		product(product),
		price(price),
		quantity(quantity) {
	}
	string getTown() {
		return this->town;
	}
	double getPrice() {
		return this->price;
	}
	double getQuantity() {
		return this->quantity;
	}
};

class ListOfSales{
private:
	map<string, double> sales;
public:
	ListOfSales() {}
	void addSale(Sale s) {
		sales[s.getTown()] += s.getPrice()*s.getQuantity();
	}
	string getInfo() {
		ostringstream ostr;
		ostr << fixed << setprecision(2);
		for (auto s : sales) {
			ostr << s.first << " -> " << s.second << endl;
		}
		return ostr.str();
	}
};

int main() {
	ListOfSales sales;
	int n;
	cin >> n;
	string town,product;
	double price;
	double quantity;
	for (int i = 0; i < n; ++i) {
		cin >> town >> product >> price >> quantity;
		sales.addSale(Sale(town, product, price, quantity));
	}
	cout << sales.getInfo();
	system("pause");
}