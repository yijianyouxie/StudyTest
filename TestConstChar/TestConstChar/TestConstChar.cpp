// TestConstChar.cpp : 定义控制台应用程序的入口点。
//

#include "stdafx.h"
#include <iostream>
using namespace std;

void TestConstChar()
{
	char str[] = "Hello world!";
	char str2[] = "Hello Lua!";

	const char* p1 = str;
	cout << str << endl;
	str[0] = 'M';
	cout << str << endl;
	//p1[1] = 'H';//改变指针指向的值，报错
	p1 = str2;//改变指针指向，可以
	cout << p1 << endl;


	char* const p2 = str2;
	cout << p2 << endl;
	//p2 = str;//改变指针指向，报错
	p2[1] = 'S';//改变指针指向的值，可以
	cout << p2 << endl;
}

int main()
{
	TestConstChar();
	system("pause");
}