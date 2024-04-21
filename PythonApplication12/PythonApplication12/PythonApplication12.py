import os
path=input('введите путь:')
clone=path
name=input('введите имя файла:')
path=path+name+".txt"
file = open(path,'r')
x=file.readlines()
print(x)
while True:
    q=input('Выбери операцию:')
    if(q=="открыть"):
        for i in range(len(x)):
            print(i,x[i],end='')
        print()
        s=input('Выберите a - дописать текст в файл; d - удалить; s - найти):')
        if s=="s":
            name=str(input("Введите имя: "))
            i=0
            while i<len(x):
                if name==x[i]:
                    print(x[i]-1+" "+x[i]+" "+x[i]+1+" "+x[i]+2)
                    i=len(x)
                i+=1
        elif(s == "a"):
            st=input('дописать текст в файл:')
            x[n]+="\n"+st+'\n'
        elif(s=='d'):
            x[n]=" "
        else:
            print('ошибка')
            continue
        file = open(path,'w')
        for i in range(len(x)):
            file.write(x[i])
        file.close()
v="C:/Users/Matros/Desktop/sold/TEXT.txt"

