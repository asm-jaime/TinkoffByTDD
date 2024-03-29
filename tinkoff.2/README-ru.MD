<!-- RUSSIAN -->
# Задача 2

Павел обучает свою модель машинного обучения для генерации текста. Обучение искусственного интеллекта — очень непростая задача, однако наш герой уже добился каких-то результатов и теперь хочет оценить качество текстов, которые у него получаются.

Паша пока не придумал хорошего способа оценить получающиеся тексты, поэтому для каждого из них он хочет узнать две простые характеристики - длину минимальной и максимальной строки в полученном тексте.

Помогите начинающему исследователю и напишите программу, которая будет находить необходимые характеристики для сгенерированного текста.

### Формат входных данных 

В первой строке входного файла дано одно целое число n - длина сгенерированного текста (1≤n≤10\^6).

Во второй строке записан сгенерированный текст, состоящий из строчных и заглавных букв латинского алфавита, нижнего подчеркивания и символа "#". Символ "#" используется в качестве символа переноса строки.

### Формат выходных данных 

В одной строке выведите два целых числа - минимальную и максимальную длину строки в тексте.

### Система оценки

Баллы за каждую подзадачу начисляются только в случае, если все тесты этой подзадачи и необходимых подзадач успешно пройдены.

Пример 1

in:
```
5
a#aba
```
out:
```
1 3
```

Пример 2

in:
```
31
You_know#how_to_solve#this_task
```
out:
```
8 12
```

Пример 3

in:
```
9
a#b##c#d#
```
out:
```
0 1
```
