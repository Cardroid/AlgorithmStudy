import sys
from collections import deque

input = sys.stdin.readline

test_case = int(input())
queue = deque()

for t in range(test_case):

    # 초기화

    queue.clear()
    N, K = map(int, input().split())
    graph = [[] for _ in range(N)]
    in_degree = [0 for _ in range(N)]
    dp = [0 for _ in range(N)]
    build_time = list(map(int, input().split()))

    for _ in range(K):
        node_idx, next_node_idx = map(int, input().split())

        node_idx -= 1
        next_node_idx -= 1

        graph[node_idx].append(next_node_idx)
        in_degree[next_node_idx] += 1

    for i in range(0, N):
        if in_degree[i] == 0:
            dp[i] = build_time[i]
            queue.append(i)

    # 위상정렬

    while queue:
        current_node = queue.popleft()

        for i in graph[current_node]:
            in_degree[i] -= 1

            dp[i] = max(dp[current_node] + build_time[i], dp[i])

            if in_degree[i] == 0:
                queue.append(i)

    last_node_idx = int(input())
    print(dp[last_node_idx - 1])
