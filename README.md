# Control test

## Задача

*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами*

**Алгоритм решения:**
* Зададим массив
* Проинициализируем новый массив и переменную count
* Создадим метод, к-й циклом проходит по всем значениям массива, и записывает в новый массив те зн-я, к-е меньше либо равы 3. При каждом True в цикле - увеличивается переменная count на 1 и возвращается к циклу for.
* Создадим еще один метод, к-й выводит полученный массив в консоль

![Графическое изображение алгоритма](DiagramForControlTest.png)
