import sys

input = sys.stdin.readline

N = int(input())

table = []

for i in range(N):
    table.append(list(map(int, input().split())))

for k in range(N):
    for i in range(N):
        for j in range(N):
            if table[i][k] == 1 and table[k][j] == 1:
                table[i][j] = 1


for r in table:
    for c in r:
        print(c, end=" ")
    print()
