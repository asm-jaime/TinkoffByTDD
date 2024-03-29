<!-- RUSSIAN -->
# Задача 3

Мария занимается строительством города в известной мобильной игре.

Каждый район города имеет свою целочисленную высоту над поверхностью ai. В этой игре проходит ровно одна дорога, которая соединяет собой n районов этого города. Дорога плавно преодолевает перепады высот в городе. Например, если два соседних района i и i+1 имеют разные высоты x и y (x<y), то дорога плавно поднимается от района i к району i+1. Точно так же дорога может спускаться.

Сегодня Маша узнала, что наконец может превратить дорогу в автомобильную магистраль. В отличие от обычной дороги, магистраль проходит на одном и том же расстоянии от поверхности во всех районах.

Мария хочет перестроить имеющуюся у нее дорогу в магистраль таким образом, чтобы суммарный уровень дороги во всех точках не изменился. То есть она хочет выбрать такую высоту магистрали, чтобы суммарная площадь в разрезе на которую придется поднять некоторые участки дороги была равна суммарной площади, на которую нужно будет опустить другие участки дороги.

Помогите Маше и найдите уровень над поверхностью, на котором необходимо построить магистраль.

### Формат входных данных 

В первой строке входных данных дано одно число n - число районов в городе(1≤n≤5*10\^5). Во второй строке дано n целых чисел ai - уровни районов города (0≤ai≤10\^5).

### Формат выходных данных 

Выведите единственное вещественное число - ответ на задачу. Точность ответа должна быть не меньше 10\^-4.

### Система оценки 

Баллы за каждую подзадачу начисляются только в случае, если все тесты этой подзадачи и необходимых подзадач успешно пройдены.

Пример 1

in:
```
3
1 2 3
```
out:
```
2.0
```

Пример 2

in:
```
4
1 1 1 1
```
out:
```
1.0
```

Пример 3

in:
```
4
0 1 1 0
```
out:
```
0.6666666666666666
```
