#include <iostream>

using namespace std;

int main()
{
    //Given 4 numbers - x1, x2, x3, x4
    //x1 + x2 + x3 + x4 = k
    //How many pairs (x1, x2, x3, x4) could be made

    int pairs = 0;
    int k = 100;
    for (int i = 0; i < k + 1; ++i) {
        pairs += (i + 1) * (k - i + 1);
    }
    cout << "Number of pairs: " << pairs << '\n';
}
