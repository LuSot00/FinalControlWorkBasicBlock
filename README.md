# FinalControlWorkBasicBlock
## **Задача:**
## Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

[“1234”, “1567”, “-2”, “computer science”] → [“-2”]

[“Russia”, “Denmark”, “Kazan”] → []


# Решение
1. Создание однострочного массива.
2. Заполнение массива.
3. Подсчет количества элементов массива, у которых количество символов *меньше или равно 3*.
4. Создание нового массива длиной равной количеству элементов из пункта 3.
5. Поочередная запись элементов, количество символов которые меньше или равно 3, в новую матрицу.
6. Вывод первоначальной и новой матриц.