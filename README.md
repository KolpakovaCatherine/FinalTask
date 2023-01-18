# Итоговая проверочная работа
 
    Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

### Текстовое описание решения:
1. Пользователь вводит текст, разделяя символы пробелом. Используется метод ReadStr для вывода информационного текста и выводы окна для ввода данных пользователем.
2. Вводится значение разделяющего символа symbol - пробел.
3. Объявляется массив и заполняется символами из текста, введенного пользователем, разделяя текст на элементы массива с помощью пробела.
4. Объявляется второй массив, длиной аналогичной первому массиву.
5. Вызывается метод LessThenThree, в котором:
- переменной count присвоено значение 0 для того, чтобы при пропуске неподходящего символа в первом массиве не пропускался элемент во втором массиве (если бы мы поставили счетчик в цикл);
- переменной symbol присвоено значение 3 для поиска строк, длина которых меньше, либо равна 3 символам;
- запускается цикл, пока не дойдет до конца массива, в котором проверяется условие ( элемент массива <=3 символов): если да, то этот элемент первого массива заносится в count элемент второго массива. После присвоения увеличивается переменная count на 1 и возвращается к циклу for в котором i увеличивается на 1. И так проверяется до конца первого масиива.
6. Выводится информационное сообщение для пользователя.
7. Выводится новый массив, который состоит из строк изначального массива, длина которых меньше, либо равна 3 символам. Вывод массива с помощью метода PrintArray, где с помощью цикла мы выводим массив поэлементно.

### Блок-схема алгоритма представлена в папке Algorithm.

### Код решения задачи в папке Task.