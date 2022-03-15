test = int(input())

for i in range(test):
    count = 0
    a, b = map(int, input().split())

    for j in range(a, b + 1):
        w = str(j)
        count += w.count("0")

    print(count)
