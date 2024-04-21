
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
                                 values=[
