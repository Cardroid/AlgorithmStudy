import sys

input = sys.stdin.readline

N = int(input())
array = [i for i in range((N + 1) ** 2)]

U = []

for i in range(N):
    U.append(int(input()))

for c in U:
    for d in U:
        if c != d:
            array[c * N + d] = U[c] + U[d]

array = list(filter(lambda x: x in U, array))

array = sorted(array, reverse=True)

print(array[0])