import sys
from itertools import combinations

input = sys.stdin.readline

while True:
    table = list(map(int, input().split(" ")))

    if table[0] == 0:
        break

    del table[0]

    table = combinations(table, 6)

    for r in table:
        for c in r:
            print(c, end=" ")
        print()
    print()
