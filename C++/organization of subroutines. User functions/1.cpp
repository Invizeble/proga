#include <iostream>
#include <cmath>

using namespace std;


double f(double x) {

	if (x < 0.1) {
		return x;
	}


	x = 5 * 3 * x + pow(sin(x), 2);
	return x;
}

int main()
{
    double a, b, ans;

    cout << "Enter A & B by , : ";
    cin >> a;
    cin.ignore(1, ',');
    cin >> b;


    double fa = f(a);
    double fb = f(b);


    if (fa == fb) {
        cout << "Error: Division by zero!";
        return 1;      
    }

    ans = (fa * fb) / (fa - fb);

    cout << "Y equals: " << ans << endl;
}