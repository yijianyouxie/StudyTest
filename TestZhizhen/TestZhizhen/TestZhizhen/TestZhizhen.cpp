// TestZhizhen.cpp : �������̨Ӧ�ó������ڵ㡣
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
	//char *p = a;//p��һ��ָ�룬ָ��a[20]���char�������λ
	////*p��ʾָ��pָ��ĵ�ַ�ϴ洢��ֵ
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

	//�ڽ��в�������ʱ��������Զ��˻�Ϊͬ���͵�ָ�룬Ҳ�����˻�Ϊint *
	function(a);

	system("PAUSE ");
    return 0;
}


