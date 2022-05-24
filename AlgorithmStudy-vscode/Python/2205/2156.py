import sys

input = sys.stdin.readline

n = int(input())
array = [0 for _ in range(10000)]

for i in range(n):
    array[i] = int(input())

dp = [0 for _ in range(10000)]
dp[0] = array[0]
dp[1] = array[0] + array[1]
dp[2] = max(dp[1], array[2] + array[0], array[2] + array[1])

for i in range(3, n):
    dp[i] = max(dp[i - 1], array[i] + dp[i - 2], array[i] + array[i - 1] + dp[i - 3])  # ~ 3, 2 4, 1 3 4

print(max(dp))
