using System;

public class Point3D
{
    private int x;
    private int y;
    private int z;

    public Point3D(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public bool AreCoordinatesInteger()
    {
        return x % 1 == 0 && y % 1 == 0 && z % 1 == 0;
    }

    public bool IsInFirstOctant()
    {
        return x > 0 && y > 0 && z > 0;
    }
}
