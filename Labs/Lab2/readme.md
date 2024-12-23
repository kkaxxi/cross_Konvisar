# Варіант 30

За квитками на прем'єру нового мюзиклу вишикувалася черга з N осіб, кожен із яких хоче купити 1 квиток. На всю чергу працювала лише одна каса, тому продаж квитків йшов дуже повільно, наводячи «постояльців» черги у відчай. Найкмітливіші швидко помітили, що, як правило, кілька квитків в одні руки касир продає швидше, ніж коли ці квитки продаються по одному. Тому вони запропонували кільком людям, які стоять поряд, віддавати гроші першому з них, щоб він купив квитки на всіх.

Однак для боротьби зі спекулянтами касир продавала не більше 3-х квитків в одні руки, тому домовитися таким чином між собою могли лише 2 або 3 особи, що стояли поспіль.

Відомо, що на продаж i-й людині з черги одного квитка касир витрачає Ai секунд, на продаж двох квитків – Bi секунд, трьох квитків – Ci секунд. Напишіть програму, яка підрахує мінімальний час, за який могли обслуговувати всі покупці.

Зверніть увагу, що квитки на групу людей, що об'єдналися, завжди купує перший з них. Також ніхто з прискорення не купує зайвих квитків (тобто квитків, які нікому не потрібні).

№ INPUT.TXT OUTPUT.TXT
1 55 10 152 10 155 5 520 20 120 1 1 12
2 23 4 51 1 1 4

## Вхідні дані

У вхідному файлі INPUT.TXT записано спочатку число N — кількість покупців у черзі (1≤N≤5000). Далі йде N трійок натуральних чисел Ai, Bi, Ci. Кожен із цих чисел не перевищує 3600. Люди в черзі нумеруються, починаючи від каси.

## Вихідні дані

У вихідний файл OUTPUT.TXT виведіть одне число - мінімальний час у секундах, за який могли обслуговувати всі покупці.

## Приклад

| №   | INPUT.TXT | OUTPUT.TXT |
| --- | --------- | ---------- |
| 1   | 5         | 12         |
|     | 5 10 15   |            |
|     | 2 10 15   |            |
|     | 5 5 5     |            |
|     | 20 20 1   |            |
|     | 20 1 1    |            |
