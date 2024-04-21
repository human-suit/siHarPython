import os
path=input('введите путь:')
clone=path
name=input('введите имя файла:')
path=path+name
file = open(path,'r')
x=file.readlines()
while True:
    q=input('Выбери операцию:')
    if(q=="открыть"):
        for i in range(len(x)):
            print(i,x[i],end='')
        print()
        s=input('Выберите что делать со строкой (w - перезаписать её; a - дописать текст в файл; d - удалить строку):')
        n=int(input('Введите номер строки:'))

        if(s=='w'):
            st=input('перезапись строки:')
            x[n] = st + "\n"
            x[n] = x[n].replace("\n", "")
        elif(s == "a"):
        
            st=input('дописать текст в файл:')
            x[n]+="\n"+st+'\n'
        elif(s=='d'):
            x[n]=" "
        else:
            print('ошибка')
            continue
        print(x)
        file = open(path,'w')
        for i in range(len(x)):
            print(x[i])
            file.write(x[i])
        file.close()
    import shutil
    if q=="open":
        file = open(path,'w')
        for i in range(len(x)):
            file.write(x[i])
        file.close()
        s=input('Выберите команду move - перемещение файла,copy - копирование файла,delete - удаление файла,rename - переименовать файл,close - выбрать дургой файл:')
        if s=='close':
            path=input('введите путь:')
            name=input('введите имя файла:')
            path=path+name
            file = open(path,'r')
            x=file.readlines()
        if s =='move':
            path2=input('Куда хотите переместить файл?')
            if(os.path.exists(path2+name)):
                s=input('Заменить этот файл?да\нет?')
                if(s=='да'):
                    os.remove(path2+name)
                if(s=='нет'):
                    print('Перемещение отменено')
            shutil.move(path,path2)
            path=path2+name
            clone=path2
            print('Перемещение завершено')

        if s=='copy':
            path2=input('Куда вы хотите копировать файл?:')
            shutil.copyfile(path,path2+name)
            print('копирование завершено')
        elif s=='delete':
            if input('Вы уверенны,что хотите удалить файл?да/нет?')=='да':
                os.remove(path)
            else:
                print('удаление отмененно')
            print('файл удален')
        elif s=='rename':
            newname=input('Введите новое имя:')+'.txt'
            path3=clone+newname
            new=open(path3,'w')
            new.writelines(x)
            os.remove(path)
            name=newname
            path=clone+name
            new.close()

