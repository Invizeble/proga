#include <iostream>

using namespace std;

double max(double x, double y) {

    if (x > y) {
        return x;
    }
    else {
        return y;
    }
}


int main() {

    double a, b, sum;

    cout << "Enter a and b ";
    cin >> a;
    cin.ignore(1, ',');
    cin >> b;

    sum = max(a, 2 * b) + max(2 * a - b, b);

	cout << "sum is: " << sum;

}