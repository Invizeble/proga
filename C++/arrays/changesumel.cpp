#include <iostream>

using namespace std;

int main() {
       
    int n;
    
    cout << "Size of array: ";
    cin >> n;

    
    int* arr = new int[n];


    for (int i = 0; i < n; i++){
        
        cin >> arr[i];
    }

    for(int i = 0; i < n ; i++){

        if(arr[i] % 3 == 0){
            arr[i] = arr[i] + i;
        }
    }
    
    for(int i = 0; i < n ; i++){
        cout << arr[i] << ", ";
    }
}