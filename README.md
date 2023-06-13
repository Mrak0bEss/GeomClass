# GeomClass
## Задача с SQL:
```sql
SELECT p.Name, c.Name
FROM Products p
LEFT JOIN ProductsCategories pc
	ON p.Id = pc.ProductId
LEFT JOIN Categories c
	ON pc.CategoryId = c.Id;
ORDER BY p.Name;
```
###C# class:
```csharp
 public class Figure
    {
        public double Square { get; set; }
        public virtual double GetSquare()
        {
            return Square;
        }


    }
    ```
    ```csharp
    public class Circle : Figure
    {
        public double rad { get; set; }
        public Circle(double r)
        {
            rad = r;
        }
        public override double GetSquare()
        {
            Square = Math.PI * rad * rad;
            return Square;
        }

    }
     public class Triangle : Figure
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public Triangle(double a1, double b1, double c1)
        {
            a = a1;
            b = b1;
            c = c1;
            if (a * a + b * b == c * c || a * a + c * c == b * b || c * c + b * b == a * a)
            {
                Console.WriteLine("Прямоугольный треугольник");
            }

        }
        public override double GetSquare()
        {
            double polyperimetr = (a + b + c) / 2;
            Square = Math.Sqrt(polyperimetr * (polyperimetr - a) * (polyperimetr - b) * (polyperimetr - c));
            return Square;
        }
    }
    ```
