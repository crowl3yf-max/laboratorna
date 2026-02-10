#include <iostream>
#include <string>
#include "ryad.h"

int main()
{
    ryad ryadok;
    ryadok.value = "zadacha";
	cout << "Рядок: ";
    ryadok.show();
    cout << "Довжина: " << ryadok.length() << endl;
    ryadok.sort();
    cout << "Відсортований рядок: ";
    ryadok.show();
    return 0;
}