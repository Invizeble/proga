#include <iostream>
#include <list>

using namespace std;


int simp(int number) {
	if (number < 10 || number >= 100) {
		return -1; 
	}

	for (int i = 2; i <= sqrt(number); i++) {
		if (number % i == 0) {
			return -1;
		}
	}
	return number;
}



int main() {
	srand(time(0));

	list<int> my_List;

	for (int i = 0; i < 10; ++i) {

		int randomnumber = rand() % 101;
		my_List.push_back(randomnumber);

	}

	for(int number : my_List) {
		if (simp(number) != -1) {
			cout << number << " - simple" << endl;
		}
		else {
			cout << number << " - not simple or not in range from 10 to 99" << endl;
		}
	}


}