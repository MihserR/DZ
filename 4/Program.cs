// Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine("Выберите нужный пункт (1 или 2) из нижеуказанных:");
Console.WriteLine("1. Расстояние между точками в пространстве 2D");
Console.WriteLine("2. Расстояние между двумя в пространстве 3D");
int a = int.Parse(Console.ReadLine());
if (a == 1)
{
    Console.WriteLine("Введите координаты первой точки x1:");
    int x1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты первой точки y1:");
    int y1 = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Введите координаты второй точки x2:");
    int x2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты второй точки y2:");
    int y2 = int.Parse(Console.ReadLine());
    
    double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    Console.WriteLine("Растояние между точками в пространстве 2D =" + d);
}
if (a == 2)
{
    Console.WriteLine("Введите координаты первой точки x1:");
    int x1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты первой точки y1:");
    int y1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты первой точки z1:");
    int z1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты второй точки x2:");
    int x2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты второй точки y2:");
    int y2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты второй точки z2:");
    int z2 = int.Parse(Console.ReadLine());
    double d = Math.Pow((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) * 1.0), 0.5);
    Console.WriteLine("Растояние между точками в пространстве 3D =" + d);
}