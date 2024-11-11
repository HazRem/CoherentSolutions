public class Point
{
    private double[] coordinates = new double[3];
    private double mass;

    public double X
    {
        get => coordinates[0];
        set => coordinates[0] = value;
    }

    public double Y
    {
        get => coordinates[1];
        set => coordinates[1] = value;
    }

    public double Z
    {
        get => coordinates[2];
        set => coordinates[2] = value;
    }

    public double Mass
    {
        get => mass;
        set => mass = value >= 0 ? value : 0;
    }

    public Point(double x, double y, double z, double mass)
    {
        X = x;
        Y = y;
        Z = z;
        Mass = mass;
    }

    public bool IsZero()
    {
        return X == 0 && Y == 0 && Z == 0;
    }

    public double DistanceTo(Point other)
    {
        if (other == null) return -1;
        double dx = X - other.X;
        double dy = Y - other.Y;
        double dz = Z - other.Z;
        return Math.Sqrt(dx * dx + dy * dy + dz * dz);
    }
}