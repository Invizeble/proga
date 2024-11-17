#include <iostream>

using namespace std;

int main(){

          
    int n, s=0;
    
    cout << "Size of array: ";
    cin >> n;

    
    int* arr = new int[n];


    for (int i = 0; i < n; i++){
        
        cin >> arr[i];
    }

    for(int i = 0; i < n ; i++){

        if(arr[i] == 0){
            s += 1;
        }
    }

    if(s == 3){
        cout << "True";
    }
    else{
        cout << "False";
    }
}