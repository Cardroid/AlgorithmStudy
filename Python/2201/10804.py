cards = [i + 1 for i in range(20)]

for i in range(10):
    m, n = map(int, input().split())
    a = cards[: m - 1]
    b = cards[m - 1 : n][::-1]
    c = cards[n:]
    cards = a + b + c

for i in cards:
    print(i, end=" ")
