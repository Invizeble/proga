#include <iostream>

using namespace std;


double f(double x) {
	x = pow(x, 3) + 2 * atan(x);
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


	double fa = f(a);
	double fb = f(b);
	double f4c = pow(f(c), 2);

	if (f4c == 0) {
		cout << "Error: Division by zero!";
		return 1;
	}


	ans = (fa - fb) / (f4c);

	cout << "Y equals: " << ans;

}