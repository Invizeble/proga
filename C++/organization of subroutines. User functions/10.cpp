#include <iostream>
#include <cmath>

using namespace std;

double f(double x) {

	double sinx3 = sin(pow(x, 3));
	x = pow(x, 5) + pow(sinx3,2);
	return x;
}


int main() {

	double x1, x2, x3, ans;


	cout << "Enter x_1 , x_2 , x_3: ";
	cin >> x1;
	cin.ignore(1, ',');
	cin >> x2;
	cin.ignore(1, ',');
	cin >> x3;

	ans = f(x1) + f(x2) * f(x3);
	cout << "y equals: " << ans;
}

