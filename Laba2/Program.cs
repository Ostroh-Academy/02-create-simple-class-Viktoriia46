using System;

class Program
{
    static void Main(string[] args)
    {
        int x, y, z;

        Console.WriteLine("Enter coordinates for the point in 3D space:");
        Console.Write("X: ");
        x = int.Parse(Console.ReadLine());
        Console.Write("Y: ");
        y = int.Parse(Console.ReadLine());
        Console.Write("Z: ");
        z = int.Parse(Console.ReadLine());

        Point3D point = new Point3D(x, y, z);

        if (point.AreCoordinatesInteger())
        {
            Console.WriteLine("All coordinates are integers.");
        }
        else
        {
            Console.WriteLine("Not all coordinates are integers.");
        }

        if (point.IsInFirstOctant())
        {
            Console.WriteLine("The point is in the first octant.");
        }
        else
        {
            Console.WriteLine("The point is not in the first octant.");
        }
    }
}
