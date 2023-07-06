// TestConstChar.cpp : 定义控制台应用程序的入口点。
//

#include "stdafx.h"
#include <iostream>
#include <csignal>
#include <windows.h>
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

void TestPoint()
{
	double* p = NULL;//此时，p是空指针
	//cout << p << "==" << &p << "==" << *p << "==" << &(*p) << endl;
	p = new double(1);

	cout << p << "==" << &p << "==" << *p << "==" << &(*p) << endl;
}

class A
{
public:
	A()
	{
		cout << "A构造函数" << endl;
	}
	~A()
	{
		cout << "A析构函数" << endl;
	}
	void print()
	{
		cout << "a:" << a << "b:" << b << endl;
	}
private:
	int a = 0;
	int b = 0;
};
void TestNewMalloc()
{
	cout << "测试malloc" << endl;
	A* a = (A*)malloc(sizeof(A));
	a->print();
	delete a;

	cout << "测试new" << endl;
	A* b = new A();
	b->print();
	delete b;
}

void SignalHandler(int sigNum)
{
	cout << "sigNum:" << sigNum << endl;

	exit(sigNum);
}
void TestSignal()
{
	signal(SIGINT, SignalHandler);

	int i = 0;
	while (i >= 0)
	{
		cout << "Going to sleep..." << endl;
		if (i == 3) {
			raise(SIGINT);
		}
		i++;
		Sleep(1000);
	}
}

int main()
{
	//TestConstChar();
	TestPoint();
	//TestNewMalloc();
	//TestSignal();
	system("pause");
}