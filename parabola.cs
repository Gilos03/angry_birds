using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WpfApp
{
    class ParapolaFlight
    {
        readonly double V0;
        readonly double alpha;
        readonly double weight;
        readonly double g = 9.8;
        public List<Point_and_Velocity> Points = new List<Point_and_Velocity>;
        double splitting = 1;

        public ParapolaFlight(double V0, double alpha, double weight, double splitting)
        {
            this.V0 = V0;
            this.alpha = alpha;
            this.weight = weight;
            this.splitting = splitting;
        }

        public Point_and_Velocity GetPosition(List<Point_and_Velocity> Points, Int32 i, double dt, double dy, double m, double k)
        {
            double x = Points[i-1].x + dt * Points[i-1].Vx;
            double y = Points[i-1].y + dt * Points[i-1].Vy;

            double Vx = Points[i-1].Vx - k * dt * Points[i-1].Vx/m;
            double Vy = Points[i-1].Vy - dt*(g + k * Points[i-1].Vy/m);

            return new Point_and_Velocity(x, y, Vx, Vy);
        }

        public void calculation(double x0, double y0)
        {
            double t = 0;
            double T = 2 * V0 * Math.sin(alpha) / g;

        }
    }

}