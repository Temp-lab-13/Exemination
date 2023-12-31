## Итогова контрольная работа Основного блока

### Задача:

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
<hr>

### Примеры:

* [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

* [“1234”, “1567”, “-2”, “computer science”] → [“-2”]

* [“Russia”, “Denmark”, “Kazan”] → []

<hr>

>**Создание строкового массива**

Создаём одномерный массив строкового стипа `string`, и заполняем его элементами с разной длиной символов кажого.

<br>

>**Условие**

Создаётся отдельная перменная целочисленного типа, `int`, которая будет хранить 'условие' - допустимую длину элементов, которые могут быть записанны в новый массив.

В нашем случаи, длина символов элемента массива не должна привышать 3-х.

<br>

>**Поиск длины нового массива**

Прежде всего необходимо найти значение длины для нового массива. Она будет равна колличеству элементов в первом массиве, подходящих под условие.

Создаём метод, который пройдёт по всем элементам массива (`foreach`) и посчитает те, которые подходят под условие.
Для этого мы заведём специальную переменную-счётчик типа `int`, которая будет увеличиваться, каждый раз как будет выполняться условие:
```C#
if(длина элемента <= условие)
```
Получившиеся значение возвращается функцией и будет использоваться в слудующем методе.

<br>

>**Заполнение нового массива**

Зная длину нового массива, переходим к его созданию и заполнению. Для последнего, вызываем ещё один метод, которвй возвращает строковый массив. 

Метод принимает аргументами: полученное предыдущей функцией значение длины, а так же сортируемый массив и 'Условие'.

Аргумент длины определяет размер массива создаваемого внутри метода. 

После мы с помощью цикла `for` пробегаемся по полученному массиву, и записываем подходящие по условию элементы в новый массив. 

<br>

>**Распечатываем первый и новый массив.**

Выводим первоначальный массив и отсортированный на консоль.