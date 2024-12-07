using System;

// Клас "Прямокутник"
public class Rectangle
{
    protected double a1, a2, b1, b2; // Коефіцієнти прямокутника
    protected double x, y; // Координати точки

    // Метод для задання коефіцієнтів
    public virtual void SetCoefficients()
    {
        Console.WriteLine("Введіть коефіцієнт a1: ");
        a1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введіть коефіцієнт a2: ");
        a2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введіть коефіцієнт b1: ");
        b1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введіть коефіцієнт b2: ");
        b2 = double.Parse(Console.ReadLine());
    }

    // Метод перевірки точки
    public virtual void CheckPoint()
    {
        Console.WriteLine("Введіть координати точки:");
        Console.Write("x: ");
        x = double.Parse(Console.ReadLine());
        Console.Write("y: ");
        y = double.Parse(Console.ReadLine());

        if (b1 <= x && x <= a1 && b2 <= y && y <= a2)
        {
            Console.WriteLine("Точка знаходиться всередині прямокутника.");
        }
        else
        {
            Console.WriteLine("Точка знаходиться за межами прямокутника.");
        }
    }

    // Метод для виведення коефіцієнтів
    public virtual void DisplayCoefficients()
    {
        Console.WriteLine($"Коефіцієнти прямокутника: a1 = {a1}, b1 = {b1}, a2 = {a2}, b2 = {b2}");
    }
}

// Похідний клас "Паралелепіпед"
public class Parallelepiped : Rectangle
{
    private double a3, b3; // Додаткові коефіцієнти
    private double z; // Координата z для точки

    // Перевизначений метод для задання коефіцієнтів
    public override void SetCoefficients()
    {
        base.SetCoefficients();
        Console.WriteLine("Введіть коефіцієнт a3: ");
        a3 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введіть коефіцієнт b3: ");
        b3 = double.Parse(Console.ReadLine());
    }

    // Перевизначений метод перевірки точки
    public override void CheckPoint()
    {
        Console.WriteLine("Введіть координати точки:");
        Console.Write("x: ");
        x = double.Parse(Console.ReadLine());
        Console.Write("y: ");
        y = double.Parse(Console.ReadLine());
        Console.Write("z: ");
        z = double.Parse(Console.ReadLine());

        if (b1 <= x && x <= a1 && b2 <= y && y <= a2 && b3 <= z && z <= a3)
        {
            Console.WriteLine("Точка знаходиться всередині паралелепіпеда.");
        }
        else
        {
            Console.WriteLine("Точка знаходиться за межами паралелепіпеда.");
        }
    }

    // Перевизначений метод для виведення коефіцієнтів
    public override void DisplayCoefficients()
    {
        Console.WriteLine($"Коефіцієнти паралелепіпеда: a1 = {a1}, b1 = {b1}, a2 = {a2}, b2 = {b2}, a3 = {a3}, b3 = {b3}");
    }
}

// Клас для тестування
public class Test
{
    public static void Main(string[] args)
    {
        // Об'єкт класу "Прямокутник"
        Rectangle rectangle = new Rectangle();
        Console.WriteLine("Прямокутник:");
        rectangle.SetCoefficients();
        rectangle.CheckPoint();
        rectangle.DisplayCoefficients();

        // Об'єкт класу "Паралелепіпед"
        Parallelepiped parallelepiped = new Parallelepiped();
        Console.WriteLine("\nПаралелепіпед:");
        parallelepiped.SetCoefficients();
        parallelepiped.CheckPoint();
        parallelepiped.DisplayCoefficients();
    }
}
