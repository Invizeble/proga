#include <iostream>
#include <cmath>

using namespace std;


double f(double x, double y)	{

	x = pow(x, 2) * sinf(y);
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
	double fbc = f(b, c);
	double fb3c = f(b, 3 + c);
	double fac = f(a, c);

	if (fac == 0) {
		cout << "Error: Division by zero!";
		return 1;
	}

	ans = fab + fbc * (fb3c / fac);

	cout << "Z equals: " << ans;

}  