import sys

input = sys.stdin.readline

N = int(input())

table = [0] * (N)
result = 0


def is_die(x):
    for i in range(x):
        if table[x] == table[i] or abs(x - i) == abs(table[x] - table[i]):
            return False

    return True


def main(x) -> None:
    global result
    if x == N:
        result += 1
        return

    for i in range(N):
        table[x] = i
        if is_die(x):
            main(x + 1)
        table[x] = 0


main(0)
print(result)
