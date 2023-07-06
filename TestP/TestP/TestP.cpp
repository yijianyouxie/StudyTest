// TestP.cpp : 定义控制台应用程序的入口点。
//

#include "stdafx.h"
#include <iostream>
#include <csignal>
//#include <cstring>
using namespace std;


void signalHandler(int sigNum)
{
	cout << "error" << sigNum;
}

int main()
{

	signal(SIGINT, signalHandler);

	char name[50];
	cin >> name;
	//strcpy();

	char a = 'a';
	char b = 'b';
	char c = 'c';
	char *arr[20] = {&a,&b,&c};
	char **parr = arr;
	char *str = &a;
	str = *parr;
	str = *(parr +1);

	cout << "pause:" << str;
	cin >> name;
    return 0;
}

