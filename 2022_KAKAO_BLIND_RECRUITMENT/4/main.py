def solution(n, info):
    answer = []
    source = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0]

    return shot(n, info, 0, source)


def shot(n: int, info: list, score: int, source: list):

    for i in range(10, -1, -1):
        if info[i] < n and score + (10 - i) > score:
            source[i] += n
            shot(n - info[i] - 1, info, score + (10 - i), source)

    return source


if __name__ == "__main__":
    print(solution(5, [2, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0]))
    print(solution(1, [1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0]))
    print(solution(9, [0, 0, 1, 2, 0, 1, 1, 1, 1, 1, 1]))
    print(solution(10, [0, 0, 0, 0, 0, 0, 0, 0, 3, 4, 3]))
