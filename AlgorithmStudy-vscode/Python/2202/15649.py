import sys

input = sys.stdin.readline


N, M = list(map(int, input().split()))

array = []


def dfs():
    if len(array) == M:
        print(" ".join(map(str, array)))
        return

    for i in range(1, N + 1):
        if i not in array:
            array.append(i)
            dfs()
            array.pop()


dfs()
