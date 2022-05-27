import re
import sys

input = sys.stdin.readline

testCase = int(input())

for i in range(testCase):
    case1 = input().strip()
    case2 = input().strip()

    case1 = re.sub(r"[\(\[\{]", "(", case1)
    case1 = re.sub(r"[\)\]\}]", ")", case1)
    case1 = re.sub(r"[,;]", ",", case1)
    case1 = re.sub(r"\s+([\(\).,:]+)", r" \1 ", case1)
    case1 = re.sub(r"([\(\).,:]+)\s+", r" \1 ", case1)
    case1 = re.sub(r"\s+([\(\).,:]+)\s+", r" \1 ", case1)
    case1 = re.split(r"\s+", case1)

    case2 = re.sub(r"[\(\[\{]", "(", case2)
    case2 = re.sub(r"[\)\]\}]", ")", case2)
    case2 = re.sub(r"[,;]", ",", case2)
    case2 = re.sub(r"\s+([\(\).,:]+)", r" \1 ", case2)
    case2 = re.sub(r"([\(\).,:]+)\s+", r" \1 ", case2)
    case2 = re.sub(r"\s+([\(\).,:]+)\s+", r" \1 ", case2)
    case2 = re.split(r"\s+", case2)

    is_equal = True

    for c1, c2 in zip(case1, case2):
        is_equal = is_equal and c1.lower() == c2.lower()

    is_equal_str = "equal" if is_equal else "not equal"
    
    print(f"Data Set {i + 1}: {is_equal_str}")

    if i + 1 != testCase:
        print()