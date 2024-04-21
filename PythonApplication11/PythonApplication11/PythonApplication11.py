import os
class vavilon:
    def __init__(self,kol,eta,s,adress):
        self.kol=kol
        self.eta=eta
        self.s=s
        self.adress=adress
    def write(self):
        b=input("введите путь для создания: ")
        b+="/new.txt"
        x=open(b,'w')
        x.writelines(self.kol+"\n"+self.eta+"\n"+self.s+"\n"+self.adress"\n")
        x.close()
    def refresh(self):
        b=input("Введите путь к файлу для изменения: ")
        x=open(b,'w')
        x.writeLines(self)
        x.close()
kol=str(input("Колличество комнат: "))
eta=str(input("Этаж: "))
s=str(input("Площадь: "))
adress=str(input("Adress: "))
Dava=vavilon(kol,eta,s,adress)
while True:
        a=input("Записать файл - 1, или перезаписать файл- 2")
        if a=="1":
            Dava.write()
        if a=="2":
            Dava.refresh()
print("C:/Users/Matros/Desktop/sold")