import sys

sys.setrecursionlimit(1000000)
input = sys.stdin.readline


def find(value):
    if value == nodes[value]:
        return value

    parent = find(nodes[value])
    nodes[value] = parent
    return parent


def union(a, b):
    a = find(a)
    b = find(b)

    if a == b:
        return
    if a < b:
        nodes[b] = a
    else:
        nodes[a] = b


N, M = map(int, input().split())

nodes = [i for i in range(N + 1)]

for _ in range(M):
    command, a, b = map(int, input().split())
    if command == 0:
        union(a, b)
    elif command == 1:
        if find(a) == find(b):
            print("YES")
        else:
            print("NO")
