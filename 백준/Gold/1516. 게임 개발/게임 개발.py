import sys
from collections import deque

input = sys.stdin.readline

# 초기화

N = int(input())
graph = [[] for _ in range(N)]
in_degree = [0] * N
build_time = [0] * N
result = [0] * N
queue = deque()

for i in range(N):
    info = list(map(int, input().split()))[:-1]
    build_time[i] = info[0]
    building_info = info[1:]

    for j in building_info:
        graph[j - 1].append(i)
        in_degree[i] += 1

for i in range(N):
    if in_degree[i] == 0:
        queue.append(i)

# 위상정렬

while queue:
    current_node_idx = queue.popleft()
    result[current_node_idx] += build_time[current_node_idx]

    for node_idx in graph[current_node_idx]:
        result[node_idx] = max(result[node_idx], result[current_node_idx])
        in_degree[node_idx] -= 1

        if in_degree[node_idx] == 0:
            queue.append(node_idx)


for i in range(N):
    print(result[i])
