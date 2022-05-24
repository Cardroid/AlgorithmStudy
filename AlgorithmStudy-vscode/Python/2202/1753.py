import sys
import heapq

input = sys.stdin.readline

INF = 1000000000

v, e = map(int, input().split())
k = int(input()) - 1
table = [[] for i in range(v)]
heap = []
heap_table = [INF for i in range(v)]
heap_table[k] = 0


for i in range(e):
    a, b, w = map(int, input().split())
    table[a - 1].append((w, a - 1, b - 1))

for w, a, b in table[k]:
    heapq.heappush(heap, (0, w, a, b))

while heap:
    d, w, a, b = heapq.heappop(heap)
    temp = heap_table[a] + w

    if temp < heap_table[b]:
        heap_table[b] = temp

        for w, x, y in table[b]:
            heapq.heappush(heap, (heap_table[b], w, x, y))

for i in heap_table:
    print(i if i != INF else "INF")
