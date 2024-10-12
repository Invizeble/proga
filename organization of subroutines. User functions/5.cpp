#include <iostream>

using namespace std;

double f(double x) {

	x = sinf(pow(x, 2)) - 5 * x + 20 * logf(x);
	return x;
}

int main() {

	double a, c, ans;

	cout << "Enter A & C";
	cin >> a;
	cin.ignore(1, ',');
	cin >> c;

	double fa = f(a);
	double fc = f(c);
	double fac = f(a * c);
	double fac2 = pow(f(a / c), 2);


	if (fac2 == 0) {
		cout << "Error: Division by zero!";
		return 1;
	}


	ans = (fa * fc - fac) / (fac2);

	cout << "Y equals: " << ans;


}