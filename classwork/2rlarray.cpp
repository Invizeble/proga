#include <iostream>

using namespace std;

int main(){
    int A[10][10], m, n, s=0;
    cin >> m;
    cin >> n;

    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            cin >> A[i][j];
        }
    }

    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            s += A[i][j];
        }
    }

    for(int i = 0; i < m; i++){
        int s = 0;
        for(int j = 0; j < n; j++){
            s += A[i][j];
        }
            cout << s << endl;
    }

    for(int j = 0; j < m; j++){
       int s = 0;
        for(int i = 0; i < n; i++){
            s += A[i][j];
        }
            cout << s << endl;
    }
    

    for(int i = 0; i < m; i++){
        cout << endl;
        for(int j = 0; j < n; j++){
            cout << A[i][j] << " ";
        }
    }


}