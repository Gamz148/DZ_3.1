// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("введите координату X1: ");
    double x1 = int.Parse(Console.ReadLine());

    System.Console.WriteLine("введите координату Y1: ");
    double y1 = int.Parse(Console.ReadLine());

    System.Console.WriteLine("введите координату z1: ");
    double z1 = int.Parse(Console.ReadLine());

    System.Console.WriteLine("введите координату X2: ");
    double x2 = int.Parse(Console.ReadLine());

    System.Console.WriteLine("введите координату Y2: ");
    double y2 = int.Parse(Console.ReadLine());

     System.Console.WriteLine("введите координату z2: ");
    double z2 = int.Parse(Console.ReadLine());

        double resault = Math.Sqrt(Math.Pow(x2 - x1, 2)  + Math.Pow(y2 - y1, 2)+ Math.Pow(z2 - z1, 2));

        System.Console.WriteLine($"расстояние между точками ({x1}, {y1}, {z1}) и ({x2}, {y2}, {z2}) ровняется: {resault}");
