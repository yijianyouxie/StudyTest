#include <iostream>
using namespace std;

int main()
{
	cout << "Hello World!" << endl;
	
	system("Pause");
	return 0;
}

//解决找不到libgcc_s_dw2-1.dll问题。
//g++ -c TestHello.cpp -o file1.o
//g++ file1.o -static-libgcc -static-libstdc++ -o file1.exe