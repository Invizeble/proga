#define _USE_MATH_DEFINES

#include <cmath>
#include <iostream>


using namespace std;

double f(double z) {
    return 2 * M_PI * z; // Используем константу M_PI для π
}


// Определяем функцию F(x, y)
double F(double x, double y) {
    double fx = f(x);
    double fy = f(y);
    return (fx * fx + fy * fy) / 2;
}



int main()
{

    double x, y, ans;

    cout << "Enter X & Y: ";
    cin >> x;
    cin.ignore(1, ',');
    cin >> y;

    ans = F(x, y);
    cout << "F(" << x << ", " << y << ") = " << ans;

}