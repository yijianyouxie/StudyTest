// TestConstChar.cpp : �������̨Ӧ�ó������ڵ㡣
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
	//p1[1] = 'H';//�ı�ָ��ָ���ֵ������
	p1 = str2;//�ı�ָ��ָ�򣬿���
	cout << p1 << endl;


	char* const p2 = str2;
	cout << p2 << endl;
	//p2 = str;//�ı�ָ��ָ�򣬱���
	p2[1] = 'S';//�ı�ָ��ָ���ֵ������
	cout << p2 << endl;
}

void TestPoint()
{
	double* p = NULL;//��ʱ��p�ǿ�ָ��
	//cout << p << "==" << &p << "==" << *p << "==" << &(*p) << endl;
	p = new double(1);

	cout << p << "==" << &p << "==" << *p << "==" << &(*p) << endl;
}

class A
{
public:
	A()
	{
		cout << "A���캯��" << endl;
	}
	~A()
	{
		cout << "A��������" << endl;
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
	cout << "����malloc" << endl;
	A* a = (A*)malloc(sizeof(A));
	a->print();
	delete a;

	cout << "����new" << endl;
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