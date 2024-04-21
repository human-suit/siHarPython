def new(list2,list3,list4,list5,list1,list6):
    m=input("Введите Почту: ")
    list1+=[m]
    l=input("Введите Логин: ")
    list2+=[l]
    p=input("Введите Пароль: ")
    list3+=[str(p)]
    name=input("Введите name: ")
    list4+=[name]
    list5+=[m]+[l]+[str(p)]+[name]
    print("Пользователь зарегестрирован! ")
    vibor(list1,list2,list3,list4,list5,list6)
def log(list1,list2,list3,list4,list5,list6):
    pr=input("Введите старый логин: ")
    i=0
    while i<len(list2):
        if list2[i]==pr:
            nov=input("Введите новый логин: ")
            list2[i]=nov
            print("Login изменен!")
            vibor(list1,list2,list3,list4,list5,list6)
        if i==len(list2)-1:
            print("Неверный логин!")
            log(list1,list2,list3,list4,list5,list6)
        i+=1
def par(list1,list2,list3,list4,list5,list6):
    p=input("Введите login: ")
    i=0
    while i<len(list2):
        if p==list2[i]:
            new=input("Введите новый пароль: ")
            list3[i]=new
            vibor(list1,list2,list3,list4,list5,list6)
        if i==len(list2)-1:
            print("Неверны логин!")
            par(list1,list2,list3,list4,list5,list6)
        i+=1
def m(list1,list2,list3,list4,list5,list6):
    n=input("Введите login: ")
    i=0
    while i<len(list2):
        if n==list2[i]:
            new=input("Введите новую почту: ")
            list1[i]=new
            vibor(list1,list2,list3,list4,list5,list6)
        if i==len(list2)-1:
            print("Неверный логин!")
            m(list1,list2,list3,list4,list5,list6)
        i+=1
def nam(list1,list2,list3,list4,list5,list6):
    n=input("Введите login: ")
    i=0
    while i<len(list2):
        if n==list2[i]:
            new=input("Введите новое имя: ")
            list4[i]=new
            vibor(list1,list2,list3,list4,list5,list6)
        if i==len(list2)-1:
            print("Неверны логин!")
            nam(list1,list2,list3,list4,list5,list6)
        i+=1
def nom(list1,list2,list3,list4,list5,list6):
    n=input("Введите login: ")
    i=0
    while i<len(list2):
        if n==list2[i]:
            new=input("Введиде номер: ")
            list6+=[new]
            vibor(list1,list2,list3,list4,list5,list6)
        if i==len(list2)-1:
            print("Неверны логин!")
            nom(list1,list2,list3,list4,list5,list6)
        i+=1
def vibor(list1,list2,list3,list4,list5,list6):
    a=input("сменить номер - s\nполучить список всех пользователей(admin)\nExit-выйти из ак\nИзменить логин - b\nИзменить пароль - v\nИзменить почту - h\nИзменить имя - n\nДобавить номер - w\nполучить список намеров - z\nПолучить список имен - name\n:")
    if a=="s":
        i=0
        n=input("Введите логин: ")
        while i<len(list2):
            if n==list2[i]:
                new1=input("Введите новsй номер: ")
                list6[i]==new1
            if i==len(list2)-1:
                print("Неверны логин!")
                vibor(list1,list2,list3,list4,list5,list6)
            i+=1
    if a=="admin123":
        print(list5)
    if a=="name":
        print(list4)
        vibor(list1,list2,list3,list4,list5,list6)
    if a=="b":
        log(list1,list2,list3,list4,list5,list6)
    if a=="exit":
        vxod(list2,list3,list4,list5,list1,list6)
    if a=="v":
        par(list1,list2,list3,list4,list5,list6)
    if a=="h":
        m(list1,list2,list3,list4,list5,list6)
    if a=="n":
        nam(list1,list2,list3,list4,list5,list6)
    if a=="w":
        nom(list1,list2,list3,list4,list5,list6)
    if a=="z":
        print(list6)
        vibor(list1,list2,list3,list4,list5,list6)
def prov(list1,list2,list3,list4,list5,list6):
    lo=input("Введите логин: ")
    i=0
    while i<len(list2):
        if list2[i]==lo:
           pra=str(input("Введите пароль: "))
           j=0
           while j<len(list3):
               if list3[i]==pra:
                    print("Зашли на аккаунт")
                    print(" ")
                    vibor(list1,list2,list3,list4,list5,list6)
               if j==len(list3)-1:
                    prov(list1,list2,list3,list4,list5,list6)
               j+=1
        i+=1
    print("Error")  
    prov(list1,list2,list3,list4,list5,list6)
def vxod(list2,list3,list4,list5,list1,list6):
    a=input("Добавить нового пользователя -a\nВойти - open: ")
    if a=="a":
        new(list2,list3,list4,list5,list1,list6)
    if a=="open":
        prov(list1,list2,list3,list4,list5,list6)
    else:
        vxod(list2,list3,list4,list5,list1,list6)

class pol:
   def __init__(self,login,parol,mail,name):
       self.login=login
       self.parol=parol
       self.mail=mail
       self.name=name
   def getLogin(self):
       return self.login
   def getName(self):
       return self.name
   def getParol(self):
       return self.parol
   def getMail(self):
       return self.mail 
while True:
   list6=[]
   list1=[]
   list2=[]
   list3=[]
   list4=[]
   list5=[]
   vxod(list2,list3,list4,list5,list1,list6)
     




