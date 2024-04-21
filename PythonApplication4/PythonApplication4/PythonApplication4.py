import os.path
import shutil
import os
def peoverca(way,way2,way1,line,kol,name):
    if kol==0:
          open=input("В файле нет данных: НАПИшите - open чтобы открыть другой, -exit - выйти: ")
          if open=="open" or open=="Open":
               print(100*'\n')
               start()
          if open=="Exit" or open=="exit":
               print(100*'\n')
               os._exit(kol)
          else:
               print("Eror comand")
    else:
          vi(way2,way1,line,kol,name,way)
def save(way2,way1,line):
    way1=open(way2,'w')
    way1.writelines(line)
    way1.close()
    print(way1)
def refresh(way2,way1,num,line,kol):
    i=0
    while i<kol:
        if num==i:
            zamena=input("На что заменить? : ")
            zamena+="\n"
            line[i]=zamena
        i+=1
    save(way2,way1,line)
    print(line)
def write(way2,way1,num,line,kol):
    i=0
    while i<kol:
        if num==i:
            word=line[i]
            word=word[0:-1]
            zamena=input("Что добавить : ")
            zamena+="\n"
            if word=="":
                line[i]=zamena
            else:
                line[i]=word+" "+zamena
        i+=1
    save(way2,way1,line)
    print(line)
def delete(way2,way1,num,line,kol):
    i=0
    while i<kol:
        if num==i:
            zamena=" "
            line[i]=zamena
        i+=1
    save(way2,way1,line)
    print(line)
def vibor(r,way2,way1,num,line,kol):
        if r=="w":
            refresh(way2,way1,num,line,kol)
        if r=="a":
            write(way2,way1,num,line,kol)
        if r=="d":
            delete(way2,way1,num,line,kol)
def start():
     way2="G:/write/kykyk/"
     print("Пример пути: ",way2)
     way=input("Введите путь: ")
     if way=="exit":
        print(100*'\n')
        print("Exit")
        os._exit(int(2))
     else:
        print("Пример названия файла: name")
        name=input("Введите название файла: ")
        if name=="exit":
            print(100*'\n')
            print("Exit")
            os._exit(int(2))
        else:
            format=".txt"
            name=name+format
            way2=way+name
            if os.path.exists(way2)==True:
                while True:
                    way1=open(way2,'r')
                    line= way1.readlines()
                    kol=0
                    for lines in open(way2,'r'):
                        kol+=1
                    way1.close()
                    peoverca(way,way2,way1,line,kol,name)
           
            else:
                print("Error file is not defaind +_+")
                start()
def vi(way2,way1,line,kol,name,way):
    otv=input("Open - открыть файл,close - выбрать другой файл, move - переместить, rename - переимменовать файл, copy - копировать,delete - удалить файл: ")
    if otv=="close":
        start()
    if otv =="open": 
        i=0
        while i<kol:
            print(i,")",line[i])
            i+=1
        num=input("Введите номер строки: ")
        if num=="exit":
            print(100*'\n')
            print("Exit")
            os._exit(int(2))
        if num.isdigit()==True:
            if int(num)>=kol or int(num)<0:
                print("Error номера строки!")
                vi(way2,way1,line,kol,name,way)
            if int(num)<kol and int(num) >=0:
                r=input("w - перезаписать строку, a - дописать текст, d - удалить строку, close - закрыть файл для открытия нового, exit - выйти с программы: ")
                if r=="a" or r=="w" or r=="d":
                    vibor(r,way2,way1,int(num),line,int(kol))
                if r=="close" or r=="Close":
                    print(100*'\n')
                    start()
                if r=="exit" or r=="Exit":
                    print(100*'\n')
                    os._exit(int(num))
                if r!="a" or r!="w" or r!="d"or r=="close" or r=="Close":
                    print("Error comands")
                    print(100*'\n')
                    i=0
                    while i<kol:
                        print(i,")",line[i])
                        i+=1
                    vi(way2,way1,line,kol,name,way)
        else:
            print("Error номера строки!: ")
            vi(way2,way1,line,kol,name,way)
    if otv =="move": 
        way3=input("Куда переместить? укажите место: ")
        if way3=="":
            way3="/Users/Matros/Desktop/"
            shutil.move(way2,way3)
            way2=way3+name
            print(100*'\n')
            save(way2,way1,line)
            vi(way2,way1,line,kol,name,way)
        else:
            way3=way3+"/"+name
            if os.path.exists(way3)==True:
                o=input("Заменить ли файл?: ")
                if o=="yes" or o=="да":
                    os.remove(way3)
                    shutil.move(way2,way3)
                    way2=way3+"/"+name
                    print(100*'\n')
                    vi(way2,way1,line,kol,name,way)
                else:
                    print(100*'\n')
                    vi(way2,way1,line,kol,name,way)
            else:
                 shutil.move(way2,way3)
                 print(100*'\n')
                 vi(way2,way1,line,kol,name,way)
    if otv=="exit":
        print(100*'\n')
        print("Exit")
        os._exit(kol)
    if otv =="delete":
        da=input("Точно удалить файл?: ")
        if da=="yes" or da=="да":
            os.remove(way2)
            print(100*'\n')
            start()
        else:
            vi(way2,way1,line,kol,name,way)
    if otv=="rename":
        zam=input("Новое название файла: ")
        if zam=="":
            print("Error name is not defaind!")
        else:
            zam=zam+".txt"
            da=way+zam
            print("Переименовал!")
            fi=open(da,'w')
            fi.writelines(line)
            fi.close()
            os.remove(way2)
            way2=da
            name=zam
            vi(way2,way1,line,kol,name,way)
    if otv=="copy":
        copy(way2,name,way,way1,line,kol)
def copy(way2,name,way,way1,line,kol):
     kyda=input("Куда скопировать? :")
     if kyda=="":
        kyda="/Users/Matros/Desktop/"
        way3=kyda+"/"+name
        if os.path.exists(way3)==True:
            o=input("Заменить ли?")
            if o=="yes"or o=="да":
                shutil.copy2(way2,kyda)
                print("Скопирован!")
                vi(way2,way1,line,kol,name,way)
            else:
                copy(way2,name,way,way1,line,kol)
        else:
            print("Скопирован!")
            shutil.copy2(way2,way3)
            vi(way2,way1,line,kol,name,way)
     if kyda=="exit":
        print("Exit")
        os._exit(kol)
     else:
        way3=kyda+"/"+name
        if os.path.exists(way3)==True:
            o=input("Заменить ли?")
            if o=="yes"or o=="да":
                shutil.copy2(way2,kyda)
                print("Скопирован!")
                vi(way2,way1,line,kol,name,way)
            else:
                copy(way2,name,way,way1,line,kol)
        else:
            shutil.copy2(way2,kyda)
            print("Скопирован!")
            vi(way2,way1,line,kol,name,way)
start()
