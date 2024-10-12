#include <iostream>

using namespace std;


double f(double x) {

	if (x < 0.1) {
		return x;
	}


	x = 5 * x + sin(x);
	return x;
}



int main() {

	double a, b, c, ans;

	cout << "Enter A & B & C by , :";
	cin >> a;
	cin.ignore(1, ',');
	cin >> b;
	cin.ignore(1, ',');
	cin >> c;

	double fa = f(a);
	double fbc = f(b * c);
	double fb4 = pow(f(b), 4);
	double fac = f(a / c);

	if (fb4 == fac) {
		cout << "Error: Division by zero!";
		return 1;
	}
	

	ans = (fa + fbc)/(fb4 - fac);

	cout << "Y equals: " << ans;


}





