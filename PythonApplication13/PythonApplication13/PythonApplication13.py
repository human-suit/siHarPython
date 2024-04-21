
from tkinter import *
from tkinter import ttk
from tkinter import messagebox
import os

main = Tk()
main.geometry("200x100")
main.title("Заполнение файла")

def Exit_window():
    window_zap.destroy()


def Exit():
    main.destroy()


def File_Zap():
    name1 = grup.get()
    name2 = fio.get()
    name3 = dataroj.get()
    name4 = doljnost.get()
    if name1 != "" and name2 != "" and name3 != "" and name4 != "":
        fill = " " + name1 + ";" + name2 + ";" + name3 + ";" + name4 + "\n"
        f = open("C://Users/Matros/Downloads/WpfApp1/WpfApp1/bin/Debug/Aloha.bin", "ab+")
        f.write(fill.encode())
        f.close()
        grup_text.delete("0", "end")
        fio_text.delete("0", "end")
        dataroj_text.delete("0", "end")
        doljnost_text.set("")
    else:
        messagebox.showinfo("Заполните поля!!!")


def Zapolnit():
    if (os.path.exists("C://Users/Matros/Downloads/WpfApp1/WpfApp1/bin/Debug/Aloha.bin") == False):
        messagebox.showinfo("Файл не найден", "Файл не найден, будет создан новый")
        f = open("C://Users/Matros/Downloads/WpfApp1/WpfApp1/bin/Debug/Aloha.bin", "wb+")
        f.close()
    global window_zap
    s=0
    window_zap = Toplevel(main)
    window_zap.title("Заполнение")
    window_zap.geometry("300x250")
    label12 = Label(window_zap, text="Добавление записи:", justify=RIGHT)
    label12.place(x=90, y=0)
    global grup
    grup = StringVar()
    global grup_text
    grup_text = ttk.Combobox(window_zap, textvariable=grup,
                                 values=["Беспозвоночные","Рыбы", "Земноводные(амфибии)","Рептилии", "Птицы","Млекопитающие"])
    grup_text.grid(column=0, row=1)
    label1 = Label(window_zap, text="Группа Животного:   ", justify=RIGHT)
    label1.place(x=30, y=50)
    grup_text.place(x=150, y=50)
    
    global fio
    fio = StringVar()
    global fio_text
    fio_text = Entry(window_zap, textvariable=fio)
    label1 = Label(window_zap, text="Вид животного:", justify=RIGHT)
    label1.place(x=40, y=75)
    fio_text.place(x=150, y=75)

    global dataroj
    dataroj = StringVar()
    global dataroj_text
    dataroj_text = Entry(window_zap, textvariable=dataroj)
    label1 = Label(window_zap, text="Возраст:", justify=RIGHT)
    label1.place(x=50, y=100)
    dataroj_text.place(x=150, y=100)

    global doljnost
    doljnost = StringVar()
    global doljnost_text
    doljnost_text = ttk.Combobox(window_zap, textvariable=doljnost,
                                 values=["Мужской", "Женский"])
    doljnost_text.grid(column=0, row=1)
    label1 = Label(window_zap, text="Пол:", justify=RIGHT)
    label1.place(x=60, y=125)
    doljnost_text.place(x=150, y=125)

    button3 = Button(window_zap, text="Заполнить в файл", command=File_Zap)
    button3.place(x=50, y=170)

    button = Button(window_zap, text="Назад", command=Exit_window)
    button.place(x=200, y=170)


button1 = Button(text="Заполнить файл", command=Zapolnit)
button1.place(x=20, y=50)

button2 = Button(text="Выйти", command=Exit)
button2.place(x=130, y=50)
main.mainloop()