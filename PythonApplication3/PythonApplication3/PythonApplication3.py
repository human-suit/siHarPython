from random import randint
t=str(input("Введите строку > 10 сим: "))
list=[]
list2=[]
list3=[]
s=len(t)
if s<=10:
    print("Error")
else:
    i=0
    k=0
    print("Убераем пробелы из строки:")
    v=t.replace(" ", "")
    d=len(v)
    print("Добавляем в два списка сначала символ и его номер начиная с 0:")
    while i<5:
        r=randint(0,d-1)
        list+=[(v[r])]
        list2+=[(r)]
        i+=1
    print(list)
    print(list2)
    s=0
    i=0
    print("Переводим символы в целое цисло:")
    while i<5: 
        s+=ord(list[i])
        list3+=[ord(list[i])]
        i+=1
    print(list3)
    print("Вывод среднего арифмитическое:",s//5)
    exit=input("")

