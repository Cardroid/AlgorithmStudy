import sys

input = sys.stdin.readline

N, M = map(int, input().split())
array = list(map(int, input().split()))
sum_array = [0]

for i in range(len(array)):
    sum_array.append(sum_array[i] + array[i])

for i in range(M):
    start, end = map(int, input().split())
    print(sum_array[end] - sum_array[start - 1])
