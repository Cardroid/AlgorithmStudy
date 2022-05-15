import sys

input = sys.stdin.readline

dp = [0 for _ in range(1000001)]
dp[1] = 1
dp[2] = 2

N = int(input())

for i in range(3, N + 1):
    dp[i] = (dp[i - 1] + dp[i - 2]) % 15746  # 나머지를 구한 후 모두 더하는 것과 같다

print(dp[N])
