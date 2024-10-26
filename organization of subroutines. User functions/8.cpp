#include <iostream>
#include <cmath>

using namespace std;

double f(double x) {

	x = (tan(x) + sin(x)) / pow(x, 3);
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

	if (a == 0 || b == 0 || c == 0)	{
		cout << "Error: Division by zero!";
		return 1;
	}

	ans = f(c) - f(b) - f(a);
	cout << "y equals: " << ans;

}
