#include <stdio.h>

int main(void) {
	int test;
	int x = 0, y = 0;
	char place[81];
	int st;

	scanf("%d", &test);

	for (int i = 0; i < test; i++) {
		st = 0;
		scanf("%d %d", &x, &y);
		scanf("%s", place);

		for (int k = 0; place[k] != NULL; k++) {
			if (place[k] == '1') {
				y++;
			}
			else if (place[k] == '2') {
				x++;
				y++;
			}
			else if (place[k] == '3') {
				x++;
			}
			else if (place[k] == '4') {
				x++;
				y--;
			}
			else if (place[k] == '5') {
				y--;
			}
			else if (place[k] == '6') {
				x--;
				y--;
			}
			else if (place[k] == '7') {
				x--;
			}
			else if (place[k] == '8') {
				x--;
				y++;
			}
			else {
				st++;
				break;
			}
		}

		if (st > 0)
			printf("WRONG!\n");
		else
			printf("%d %d\n", x, y);
	}
	return 0;
}