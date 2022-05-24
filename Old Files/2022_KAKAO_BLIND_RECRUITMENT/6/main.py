def solution(board, skill):
    answer = 0

    for s in skill:

        degree = s[5] if s[0] > 1 else -s[5]

        for i in range(s[1], s[3] + 1):
            for j in range(s[2], s[4] + 1):
                board[i][j] += degree

    for i in range(len(board)):
        for j in range(len(board[i])):
            if board[i][j] > 0:
                answer += 1

    return answer


if __name__ == "__main__":
    print(solution([[5, 5, 5, 5, 5], [5, 5, 5, 5, 5], [5, 5, 5, 5, 5], [5, 5, 5, 5, 5]], [[1, 0, 0, 3, 4, 4], [1, 2, 0, 2, 3, 2], [2, 1, 0, 3, 1, 2], [1, 0, 1, 3, 3, 1]]))
    print(solution([[1, 2, 3], [4, 5, 6], [7, 8, 9]], [[1, 1, 1, 2, 2, 4], [1, 0, 0, 1, 1, 2], [2, 2, 0, 2, 0, 100]]))
