interest = float(input())
if interest > 0 and interest < 25:
    initial_deposit = int(1000)
    month_counter = int(0)
    interest = (interest + 100) / 100
    while initial_deposit < 1100:
        month_counter += 1
        initial_deposit *= interest
    print(f'{month_counter} - количество месяцев. {initial_deposit} - итоговый размер вклада.')
