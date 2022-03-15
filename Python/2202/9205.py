import sys

input = sys.stdin.readline


INF = 99999999

t = int(input())
while t > 0:
    n = int(input())

    table = [list(map(int, input().split())) for _ in range(n + 2)]
    table_dist = [[INF for _ in range(n + 2)] for _ in range(n + 2)]

    for i in range(n + 2):
        for j in range(n + 2):
            if i == j:
                continue
            dist = abs((table[i][0] - table[j][0])) + abs((table[i][1] - table[j][1]))

            if dist <= 1000:
                table_dist[i][j] = 1

    for k in range(n + 2):
        for i in range(n + 2):
            for j in range(n + 2):
                if table_dist[i][j] > table_dist[i][k] + table_dist[k][j]:
                    table_dist[i][j] = table_dist[i][k] + table_dist[k][j]

    if 0 <= table_dist[0][n + 1] < INF:
        print("happy")
    else:
        print("sad")

    t -= 1
