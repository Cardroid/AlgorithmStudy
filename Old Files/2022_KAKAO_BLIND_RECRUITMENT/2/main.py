import math


def solution(n, k):
    answer = 0

    result = convert(n, k).split("0") if k != 10 else str(n).split("0")

    for num in result:
        if num and is_prime_number(int(num)):
            answer += 1

    return answer


def is_prime_number(n):
    array = [True for i in range(n + 1)]

    # 에라토스테네스의 체
    for i in range(2, int(math.sqrt(n)) + 1):
        if array[i]:
            j = 2
            while i * j <= n:
                array[i * j] = False
                j += 1

    return [i for i in range(2, n + 1) if array[i]]


def convert(n, k):
    rev_base = ""

    while n > 0:
        n, mod = divmod(n, k)
        rev_base += str(mod)

    return rev_base[::-1]


if __name__ == "__main__":
    print(solution(437674, 3))
    print(solution(110011, 10))