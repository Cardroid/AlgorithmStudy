#include <stdio.h>

int main()
{
	int week, day, hour, min, sec;

	unsigned int number;
	//ascode 1037
	scanf("%u", &number);
	week = number / 604800;
	day = (number % 604800) / 86400;
	hour = (number % 86400) / 3600;
	min = (number % 3600) / 60;
	sec = (number % 60) / 1;

	printf("%d %d %d %d %d", week, day, hour, min, sec);

	return 0;
}