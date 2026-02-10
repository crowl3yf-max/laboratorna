#include "ryad.h"

void ryad::show()
{
	cout << value << endl;
}
int ryad::length()
{
	return value.length();
}
void ryad::sort() {
	int n = value.length();

	for (int i = 0; i < n - 1; i++) {
		for (int j = 0; j < n - 1; j++) {
			if (value[j] > value[j + 1]) {
				char temp = value[j];
				value[j] = value[j + 1];
				value[j + 1] = temp;
			}
		}
	}
}