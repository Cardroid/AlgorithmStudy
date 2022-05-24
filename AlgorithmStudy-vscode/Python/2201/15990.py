t = int(input())
n = []
for i in range(t):
    n.append(int(input()))

tm = [[0 for _ in range(3)] for _ in range(100001)]
tm[1] = [1, 0, 0]
tm[2] = [0, 1, 0]
tm[3] = [1, 1, 1]

for i in range(4, 100001):
    tm[i][0] = tm[i - 1][1] % 1000000009 + tm[i - 1][2] % 1000000009
    tm[i][1] = tm[i - 2][0] % 1000000009 + tm[i - 2][2] % 1000000009
    tm[i][2] = tm[i - 3][0] % 1000000009 + tm[i - 3][1] % 1000000009

for i in n:
    print(sum(tm[i]) % 1000000009)
