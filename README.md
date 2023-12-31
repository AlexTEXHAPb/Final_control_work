# Итоговая контрольная работа по основному блоку

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

[“1234”, “1567”, “-2”, “computer science”] → [“-2”]

[“Russia”, “Denmark”, “Kazan”] → []

# Описание алгоритма решения задачи:

Задается массив, заполненный строковыми элементами и переменная k = 0, которая нужна для подсчета количества нужных элементов. 
Далее создается цикл с количеством повторений, равным длине массива, внутри которого последовательно выводятся в терминал каждый элемент этого массива и проверяется условие: длинна i-го элемента массива <= 3. 
Если условие выполняется, то k-тому элементу массива присваивается значение i-го элемента массива, а k увеличивается на единицу и цикл повторяется. 
Если условие не выполняется, то цикл повторяется без каких-либо действий. 
В результате проверки каждого элемента массива, он перезаписывается таким образом, что каждый элемент этого массива, длина которого <= 3 символам, последовательно сохраняется в нем начиная с первого элемента. Оставшиеся элементы массива остаются без изменений. При этом в переменной k сохраняется индекс последнего перезаписанного элемента массива.
Далее задается пустой строковый массив размерностью k и создается цикл с количеством повторений равным количеству элементов исходного массива соответствующим условию. В цикле заполняется и выводится в терминал новый массив из строк, длина которых <= 3 символам.

