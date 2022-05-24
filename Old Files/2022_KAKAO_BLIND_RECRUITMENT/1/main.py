def solution(id_list, report, k):
    answer = []
    preprocessedReport = set(report)
    reportedUserDic = {}

    for reportInfo in preprocessedReport:
        reportedUser = reportInfo.split()[1]

        if reportedUser in reportedUserDic:
            reportedUserDic[reportedUser] = reportedUserDic[reportedUser] + 1
        else:
            reportedUserDic[reportedUser] = 1

    for user in id_list:
        reportCount = 0

        for reportInfo in preprocessedReport:
            temp = reportInfo.split()
            if user == temp[0] and reportedUserDic[temp[1]] >= k:
                reportCount += 1

        answer.append(reportCount)

    return answer


if __name__ == "__main__":
    print(solution(["muzi", "frodo", "apeach", "neo"], ["muzi frodo", "apeach frodo", "frodo neo", "muzi neo", "apeach muzi"], 2))
    print(solution(["con", "ryan"], ["ryan con", "ryan con", "ryan con", "ryan con"], 3))
    print(solution(["con", "ryan"], ["ryan con"], 1))