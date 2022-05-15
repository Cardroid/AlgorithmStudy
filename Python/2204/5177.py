import re
import sys

input = sys.stdin.readline

testCase = int(input())

cases = []

for i in range(testCase):
    cases.clear()
    cases.append(input().strip())
    cases.append(input().strip())

    for j in range(len(cases)):
        # 여는 괄호 문자들 => '('로 축소
        cases[j] = re.sub(r"[\(\[\{]", "(", cases[j]) 
        # 닫는 괄호 문자들 => ')'로 축소
        cases[j] = re.sub(r"[\)\]\}]", ")", cases[j]) 
        # ',' 또는 ';' 문자 => ','로 축소
        cases[j] = re.sub(r"[,;]", ",", cases[j]) 

        # "하나 이상의 공백 + 하나 이상의 특수문자" => "공백 + 하나 이상의 특수문자 + 공백"
        cases[j] = re.sub(r"\s+([\(\).,:]+)", r" \1 ", cases[j]) 
        # "하나 이상의 특수문자 + 하나 이상의 공백" => "공백 + 하나 이상의 특수문자 + 공백"
        cases[j] = re.sub(r"([\(\).,:]+)\s+", r" \1 ", cases[j]) 
        # "하나 이상의 공백 + 하나 이상의 특수문자 + 하나 이상의 공백" => "공백 + 하나 이상의 특수문자 + 공백"
        cases[j] = re.sub(r"\s+([\(\).,:]+)\s+", r" \1 ", cases[j]) 

        # 문자열을 모두 소문자로 변환
        cases[j] = cases[j].lower()
        
        # 공백을 기준으로 문자열 자르기
        cases[j] = re.split(r"\s+", cases[j])

    # 문자열들이 일치하는지 확인
    is_equal = True

    for j in range(0, len(cases), 2):
        is_equal = is_equal and cases[j] == cases[j]

    # 출력
    is_equal_str = "equal" if is_equal else "not equal"
    
    print(f"Data Set {i + 1}: {is_equal_str}")

    # 테스트 케이스마다 빈 줄 출력
    if i + 1 != testCase:
        print()