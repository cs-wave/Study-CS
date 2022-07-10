
#include <iostream>

class hi {
public:
	int i;
	static int si;
};

class Manager {
	Person persons[100];
	int count;
};

class Person {
public:
	char* name;
};

int i;

int main()
{
	hi a, b;
	a.i++;
	b.i++;

	a.si++;
	b.si++;
	hi::si;

	printf("%d %d", a.i, b.i);
}