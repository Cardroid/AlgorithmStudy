import sys

input = sys.stdin.readline

for testCase in range(int(input())):
    r1x1, r1y1, r1x2, r1y2, r2x1, r2y1, r2x2, r2y2 = map(int, input().split(" "))

    x1 = max(min(r1x1, r1x2), min(r2x1, r2x2))
    y1 = max(min(r1y1, r1y2), min(r2y1, r2y2))

    x2 = min(max(r1x1, r1x2), max(r2x1, r2x2))
    y2 = min(max(r1y1, r1y2), max(r2y1, r2y2))

    x_minus = x2 - x1
    y_minus = y2 - y1

    if x_minus <= 0 or y_minus <= 0:
        print(0)
    else:
        print(x_minus * y_minus)
