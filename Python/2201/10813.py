N, M = map(int, input().split())

balls = [i + 1 for i in range(N)]

for i in range(M):
    a, b = map(int, input().split())
    a -= 1
    b -= 1
    balls[a], balls[b] = balls[b], balls[a]

for i in balls:
    print(i, end=" ")
