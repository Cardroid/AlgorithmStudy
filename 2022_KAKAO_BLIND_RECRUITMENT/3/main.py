import datetime as dt


def solution(fees, records):
    answer = []
    recordDic = {}
    maxDatetime = dt.datetime.strptime("23:59", "%H:%M")

    (maxDatetime - maxDatetime)

    for record in records:
        temp = record.split()

        if temp[1] in recordDic:
            recordDic[temp[1]].append((dt.datetime.strptime(temp[0], "%H:%M"), temp[2]))
        else:
            recordDic[temp[1]] = [((dt.datetime.strptime(temp[0], "%H:%M"), temp[2]))]

    carNums = list(recordDic.keys())
    carNums.sort()

    for carNum in carNums:
        recordLines = recordDic[carNum]

        timeMin = 0
        money = 0
        lastInDatetime = None

        for line in recordLines:
            if line[1] == "IN":
                lastInDatetime = line[0]
            else:
                timeMin += (line[0] - lastInDatetime).seconds // 60
                lastInDatetime = None

        if lastInDatetime != None:
            timeMin += (maxDatetime - lastInDatetime).seconds // 60

        if timeMin <= fees[0]:
            money += fees[1]
        else:
            timeMin -= fees[0]
            money += fees[1]
            cnt = timeMin // fees[2]
            money += cnt * fees[3]

            if timeMin % fees[2] > 0:
                money += fees[3]

        answer.append(money)

    return answer


if __name__ == "__main__":
    print(
        solution(
            [180, 5000, 10, 600],
            ["05:34 5961 IN", "06:00 0000 IN", "06:34 0000 OUT", "07:59 5961 OUT", "07:59 0148 IN", "18:59 0000 IN", "19:09 0148 OUT", "22:59 5961 IN", "23:00 5961 OUT"],
        )
    )
    print(solution([120, 0, 60, 591], ["16:00 3961 IN", "16:00 0202 IN", "18:00 3961 OUT", "18:00 0202 OUT", "23:58 3961 IN"]))
    print(solution([1, 461, 1, 10], ["00:00 1234 IN"]))