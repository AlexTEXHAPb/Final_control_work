# Итоговая контрольная работа по основному блоку

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

[“1234”, “1567”, “-2”, “computer science”] → [“-2”]

[“Russia”, “Denmark”, “Kazan”] → []

# Описание алгоритма решения задачи:

Задается два строковых массива, один заполненный строковыми элементами, а второй пустой с таким же размером как первый. 
На следующем этапе создается цикл с количеством повторений равным длине первого массива внутри которого проверяется условие: длинна i-го элемента массива <= 3. Если условие выполняется, то k-тому элементу второго массива присваивается значение i-го элемента первого массива, а k увеличивается на единицу и цикл повторяется. Если условие не выполняется, то цикл повторяется без каких-либо действий. В результате проверки каждого элемента первого массива, перезаписывается второй массив, в который последовательно заносится каждый элемент первого массива, длина которого меньше, либо равна 3 символам, а незаполненные элементы нового массива остаются пустыми.
Перезаписанный второй массив выводим на экран.
