#include <iostream>

using namespace std;

double f(double x, double y) {

	x = cos(pow(x, 2) / 3) - y;
	return x;
}


int main() {

	double a, b, c, ans;

	cout << "Enter A & B & C: ";
	cin >> a;
	cin.ignore(1, ',');
	cin >> b;
	cin.ignore(1, ',');
	cin >> c;

	double fab = f(a, b);
	double fac = f(a, c);

	if (fac == 0) {

		cout << "Error: Division by zero!";
		return 1;
	}

	ans = fab / fac;
	cout << "Z equals: " << ans;
}