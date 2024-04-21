#Подлкючение основных функций модуля tkinter
import os
from tkinter import *
#Подключаем месседжбоксы
from tkinter import messagebox

file = open("C://Users/Matros/Desktop/TEXT.txt",'r')
nomber=""
name=""
filname=""
othest=""
data=""
work=""
x=file.readlines()
file.close
k=22
v=5
#Функция которая отрабатывает при нажатии кнопки
def click_button():
    print("Dobavil")
    nextWindow()
    k+=1
def showPassword():
        #Отображение месседжбокса
        messagebox.showinfo("Password", password.get())
    #Изменение параметра show у Entry
def checkPassword():
        if isChecked.get() == 1:
            passwordEntry.config(show='*')
        else:
            passwordEntry.config(show='')
    #Изменение параметра state у Button
def disableButton():
        if isDisabled.get() == 1:
            passwordButton.config(state='disabled')#отключение кнопки
        else:
            passwordButton.config(state='normal')#включение кнопки
    #Закрытие формы
def nextWindow():
    def destroyWindow():
        newWindow.destroy()
    #Для объектов необходимо указать на каком окне они будут созданы
    label[k] = Label( text=x[0])
    newLabel.place(x=50,y=40+v)

#Создание экземпляра класса Tk
root = Tk()
#Установка названиея окна
root.title('Первое окно')
#Установка размеров окна окна Ширина x Высота
root.geometry('500x400')
#Особая строковая переменная для хранения строковых данных из элементов форм
login = StringVar()
#Entry - поле для ввода данных
#textvariable - параметр в котором указывается к какой переменной привязано поле для ввода
loginEntry = Entry(root,textvariable=login, show='')
loginEntry.place(x=80,y=130)
password = StringVar()
#Entry - поле для ввода данных
#textvariable - параметр в котором указывается к какой переменной привязано поле для ввода
passwordEntry = Entry(root,textvariable=password, show='*')
passwordEntry.place(x=80,y=210)
#Создание кнопки
btn = Button(text="Create",          # текст кнопки 
             background="black",     # фоновый цвет кнопки
             foreground="white",     # цвет текста
             padx="20",             # отступ от границ до содержимого по горизонтали
             pady="8",              # отступ от границ до содержимого по вертикали
             font="16",             # высота шрифта
             command=click_button   #событие при нажатии
             )
#Позиционирование кнопки
btn.place(x = 100,                  #Смещение по оси x от левого верхнего угла
          y = 300,                   #Смещение по оси y от левого верхнего угла
          height = 20,             #Высота кнопки
          width = 80,              #ширина кнопки
)
label2 = Label(text="Номер:",           #текст лейбла
               justify=LEFT,       #выравнивание текста
               fg="black"            #цвет текста
               )
label2.place(x=15, y=15)
label1 = Label(text="Ф.И.О:",        #текст лейбла
               justify=LEFT,        #выравнивание текста
               fg="black"           #цвет текста
               )
label1.place(x=63, y=15)

label3 = Label(text="Год:",           #текст лейбла
               justify=LEFT,       #выравнивание текста
               fg="black"            #цвет текста
               )
label3.place(x=115, y=15)
label4 = Label(text="Должность:",           #текст лейбла
               justify=LEFT,       #выравнивание текста
               fg="black"            #цвет текста
               )
label4.place(x=145, y=15)

#Особая строковая переменная для хранения числовых данных из элементов форм
isChecked = IntVar()
#задаём ей изначально значение 1(флажок отмечен)
isChecked.set(1)
passwordCheck = Checkbutton(text="Скрыть?", variable=isChecked, command=checkPassword)
passwordCheck.place(x=220,y=210)

passwordButton = Button(text='Отобразить пароль', command=showPassword)
passwordButton.place(x=80,y = 230)

isDisabled = IntVar()
isDisabled.set(2)
#Радиобатоны; value - значение при выборе радиобатона(хранится в isDisabled)
disableRadiobutton = Radiobutton(text='close',value=1, variable=isDisabled, command=disableButton)
disableRadiobutton.place(x=220, y = 240)
enableRadiobutton = Radiobutton(text='open',value=2, variable=isDisabled, command=disableButton)
enableRadiobutton.place(x=220, y = 260)


btnOpenNextWindow = Button(text='Перейти к следующей форме',command=nextWindow)
btnOpenNextWindow.place(x=200, y = 500)


#Обязательная функция
#Прописывается в конце программы
#Реализует "бесконечный цикл" обработки событий окна
root.mainloop()


