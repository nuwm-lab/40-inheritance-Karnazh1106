using System;

public class Rectangle
{
    protected double a1, a2, b1, b2; // Коефіцієнти прямокутника
    protected double x, y; // Координати точки

    // Метод для задання коефіцієнтів
    public virtual void SetCoefficients()
    {
        Console.WriteLine("Enter coefficient a1: ");
        a1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient a2: ");
        a2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient b1: ");
        b1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient b2: ");
        b2 = double.Parse(Console.ReadLine());
    }

    // Метод для перевірки точки
    public virtual void CheckPoint()
    {
        Console.WriteLine("Enter the coordinates of the point:");
        Console.Write("x: ");
        x = double.Parse(Console.ReadLine());
        Console.Write("y: ");
        y = double.Parse(Console.ReadLine());

        if (b1 <= x && x <= a1 && b2 <= y && y <= a2)
        {
            Console.WriteLine("The point is inside the rectangle.");
        }
        else
        {
            Console.WriteLine("The point is outside the rectangle.");
        }
    }

    // Метод для виведення коефіцієнтів
    public virtual void DisplayCoefficients()
    {
        Console.WriteLine($"Rectangle coefficients: a1 = {a1}, b1 = {b1}, a2 = {a2}, b2 = {b2}");
    }
}

// Похідний клас "паралелепіпед"
public class Parallelepiped : Rectangle
{
    private double a3, b3; // Додаткові коефіцієнти
    private double z; // Координата z для точки

    // Перевизначений метод для задання коефіцієнтів
    public override void SetCoefficients()
    {
        base.SetCoefficients();
        Console.WriteLine("Enter coefficient a3: ");
        a3 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient b3: ");
        b3 = double.Parse(Console.ReadLine());
    }

    // Перевизначений метод для перевірки точки
    public override void CheckPoint()
    {
        Console.WriteLine("Enter the coordinates of the point:");
        Console.Write("x: ");
        x = double.Parse(Console.ReadLine());
        Console.Write("y: ");
        y = double.Parse(Console.ReadLine());
        Console.Write("z: ");
        z = double.Parse(Console.ReadLine());

        if (b1 <= x && x <= a1 && b2 <= y && y <= a2 && b3 <= z && z <= a3)
        {
            Console.WriteLine("The point is inside the parallelepiped.");
        }
        else
        {
            Console.WriteLine("The point is outside the parallelepiped.");
        }
    }

    // Перевизначений метод для виведення коефіцієнтів
    public override void DisplayCoefficients()
    {
        Console.WriteLine($"Parallelepiped coefficients: a1 = {a1}, b1 = {b1}, a2 = {a2}, b2 = {b2}, a3 = {a3}, b3 = {b3}");
    }
}

// Клас для тестування
public class Test
{
    public static void Main(string[] args)
    {
        // Об'єкт класу "прямокутник"
        Rectangle rectangle = new Rectangle();
        Console.WriteLine("Rectangle:");
        rectangle.SetCoefficients();
        rectangle.CheckPoint();
        rectangle.DisplayCoefficients();

        // Об'єкт класу "паралелепіпед"
        Parallelepiped parallelepiped = new Parallelepiped();
        Console.WriteLine("\nParallelepiped:");
        parallelepiped.SetCoefficients();
        parallelepiped.CheckPoint();
        parallelepiped.DisplayCoefficients();
    }
}
