X, Y = map(int, input().split())

board = [[0 for col in range(Y)] for row in range(X)]


for i in range(X):
    j = 0
    for dot in list(input()):
        board[i][j] = dot
        j += 1

r1 = 0
r2 = 0

for y in range(Y):
    b = [i[y] for i in board]
    if b.count("X") == 0:
        r1 += 1

for x in range(X):
    b = board[x]
    if b.count("X") == 0:
        r2 += 1

print(r1 if r1 > r2 else r2)
