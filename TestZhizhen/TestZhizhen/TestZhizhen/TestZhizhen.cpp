// TestZhizhen.cpp : 定义控制台应用程序的入口点。
//

#include "stdafx.h"
#include <iostream>
using namespace std;


void function(int a[])
{
	printf("%d\n", sizeof(a));
}

int main()
{
	//char a[20] = "You are a girl.";
	//char *p = a;//p是一个指针，指向a[20]这个char数组的首位
	////*p表示指针p指向的地址上存储的值
	//cout << "=======*p" << *p << "=====*(p+1)" << *(p+1) << "====p:" << p << endl;

	//char **ptr = &p;
	//cout << ptr << endl;
	//ptr++;
	//cout << ptr << endl;

	/*int a = 0;
	int* p = &a;
	cout << "=======================p:" << p << "(p+1):" << p+1 << "||*p:" << *p << "===sizeof(p)" << sizeof(p) << endl;*/

	/*int i = -3;
	uint32_t y = (uint32_t)i;
	cout << "=======================" << i << "||" << y << endl;*/



	int a[10] = { 1,2,3,4,5,6,7 };
	int *p = a;
	printf("%d %d\n", sizeof(a), sizeof(p));

	//在进行参数传递时，数组会自动退化为同类型的指针，也就是退化为int *
	function(a);

	system("PAUSE ");
    return 0;
}


