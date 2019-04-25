using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ZeoTunnel
{
    struct Point2D
    {
        double X,Y;
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
    struct Point3D
    {
        public double X, Y, Z;
        public Point3D(double x,double y,double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Point3D operator +(Point3D p1, Point3D p2)
        {
            Point3D temp = new Point3D(0, 0, 0);
            temp.X = p1.X + p2.X;
            temp.Y = p1.Y + p2.Y;
            temp.Z = p1.Z + p2.Z;
            return temp;
        }
        public static Point3D operator +(Point3D p1, double k)
        {
            return new Point3D(p1.X + k, p1.Y + k, p1.Z + k);
        }
    }
    class Line
    {
        Point3D Pass, Dir;
        public Line(Point3D pt1,Point3D pt2)
        {
            Pass = pt1;
            Dir = pt2;
        }
        /*public Point3D GetIntersetion(Plane p)
        {
            //pass
        }*/
    }
    
    class Plane
    {
        Point3D Pass, Nor;
        public Plane(Point3D pt1, Point3D pt2)
        {
            Pass = pt1;
            Nor = pt2;
        }
    }
    class Graph
    {
        double px0, py0, pxn, pyn;
        public Graph(double x0,double y0,double xn,double yn)
        {
            px0 = x0;
            py0 = y0;
            pxn = xn;
            pyn = yn;
        }
    }
    class Tunnel
    {
        double DriveDir;
        double Slope;
        char Type;
        double Width;
        double Height;
        public Tunnel(double d, double s,char t,double b,double h=0)
        {
            this.DriveDir = d;
            this.Slope = s;
            this.Type = t;
            this.Width = b;
            //t == 'C' ? this.Height = b : this.Height = h;
        }/*
        public void Draw(Point2D pt,Graph G)
        {

        }*/
    }
    class Foliation
    {
        Point3D normal;
        ArrayList Joints;
        public Foliation(double dir,double dip)
        {
            normal.X = Math.Sin(dir * Math.PI / 180);
            normal.Y = Math.Cos(dir * Math.PI / 180);
            normal.Z = Math.Tan(dip * Math.PI / 180);
        }
        public void AddJoint(Joint j)
        {
            Joints.Add(j);
        }
        public void DrawFoliation(Graph G)
        {

        }
        public void DrawMajorJoints(Graph G)
        {

        }
        public void DrawAllJoints(Graph G)
        {

        }
    }
    class Joint
    {
        Boolean IsMajor;
        Point3D normal;
        public Joint(Boolean m,double dir, double dip)
        {
            IsMajor = m;
            normal.X = Math.Sin(dir * Math.PI / 180);
            normal.Y = Math.Cos(dir * Math.PI / 180);
            normal.Z = Math.Tan(dip * Math.PI / 180);
        }
    }
}
