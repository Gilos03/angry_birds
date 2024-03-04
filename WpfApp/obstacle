using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public class Obstacle
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Radius { get; set; }

    public Obstacle(double x, double y, double radius)
    {
        X = x;
        Y = y;
        Radius = radius;
    }

    public bool CheckCollision(Point_and_Velocity point)
    {
        double distance = Math.Sqrt(Math.Pow(X - point.x, 2) + Math.Pow(Y - point.y, 2));
        return distance <= Radius;
    }
}
