using System;

class Program
{
    static void Main()
    {
        Person p1 = new Person("Bob", 33);
        Person p2 = new Person("Bob", 33);
        Console.WriteLine(p1 == p2);

        Person copyp1 = p1 with { Age = 35 };
        Console.WriteLine(p1);
        Console.WriteLine(copyp1);

        var (name, age) = p1;
        Console.WriteLine(name);
        Console.WriteLine(age);

        PersonStruct p3 = new PersonStruct("Ted", 23);
        p3.Age = 30;
        Console.WriteLine(p3);

        // p1.Age = 30;   // ошибка компиляции: у record свойство только для инициализации (init)
    }
}
