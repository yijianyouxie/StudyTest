// TestConstChar.cpp : �������̨Ӧ�ó������ڵ㡣
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
	//p1[1] = 'H';//�ı�ָ��ָ���ֵ������
	p1 = str2;//�ı�ָ��ָ�򣬿���
	cout << p1 << endl;


	char* const p2 = str2;
	cout << p2 << endl;
	//p2 = str;//�ı�ָ��ָ�򣬱���
	p2[1] = 'S';//�ı�ָ��ָ���ֵ������
	cout << p2 << endl;
}

int main()
{
	TestConstChar();
	system("pause");
}