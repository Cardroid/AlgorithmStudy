n = int(input())
map = [list(map(int, input().split())) for _ in range(n)]

temp = [[0 for _ in range(n)] for _ in range(n)]
temp[0][0] = 1

for y in range(n):
    for x in range(n):
        if temp[y][x] != 0 and map[y][x] != 0:
            if x + map[y][x] < n:
                temp[y][x + map[y][x]] += temp[y][x]
            if y + map[y][x] < n:
                temp[y + map[y][x]][x] += temp[y][x]

print(temp[-1][-1])
