import os

while True:
    way1="G:/write/kykyk/text.txt"
    way2=input("Введите путь: ")
    name=input("Введите название файла: ")
    format=".txt"
    name=name+format
    way2=way2+name
    num=input("Введите номер строки: ")
    print("w - перезаписать строку, a - дописать текст, d - удалить строку")
    w=input("")
    if w=="w":
        list=[]
        s=open(way2,'r')
        num2=0
        for line in s:
            num2+=1
            if num2==num:
                a=2
            else:
            
        print(list)
        s.close()
        s=open(way2,'w')

            
    else:
        print("Error")




