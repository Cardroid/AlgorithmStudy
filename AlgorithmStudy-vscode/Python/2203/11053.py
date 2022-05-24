import sys

input = sys.stdin.readline

N = int(input())
array = list(map(int, input().split()))
dp = [1 for _ in range(N)]

for i in range(N):
    for j in range(i):
        if dp[i] < dp[j] + 1 and array[i] > array[j]:
            dp[i] = dp[j] + 1

print(max(dp))
