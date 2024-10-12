#include <iostream>

using namespace std;

double f(double x) {

	if (x < 0.1) return x;

	x = x + pow(cos(x), 2);

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


	double ya = f(a);
	double yc = f(c);
	double ybc = f(b + c);
	double syac = 3 * f(a * c);

	if (ybc == syac) {
		cout << "Error: Division by almost zero!";
		return 1;
	}


	ans = (ya + yc) / (ybc - syac);

	cout << "Z equals: " << ans ;


}