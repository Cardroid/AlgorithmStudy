import sys

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


G = int(input())
P = int(input())

nodes = {i: i for i in range(0, G + 1)}
planes = [int(input()) for _ in range(P)]
count = 0

for plane in planes:
    parent = find(plane)

    if parent == 0:
        break

    union(parent, parent - 1)
    count += 1

print(count)
