# КТ №14 — record и record struct

**Вариант 1 — Person / PersonStruct**

## Проверочные ключи

| Действие | Ожидаемый результат |
|---|---|
| `new Person("Bob", 33) == new Person("Bob", 33)` | `True` |
| `p1 with { Age = 35 }` | новый объект, `Age == 35`; оригинал остался с `Age == 33` |
| `var (name, age) = p1;` | `name` и `age` получают значения свойств |
| `p3.Age = 30;` напрямую | компилируется и работает (в отличие от `Person.Age`, у которого `init`) |
