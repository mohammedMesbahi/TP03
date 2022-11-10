using System;
using Victor;
public class Point
{
    private int x;
    private int y;
    public Point()
    {
    }
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public int getX()
    {
        return x;
    }
    public int getY()
    {
        return y;
    }
    public void setX(int x)
    {
        this.x = x;
    }
    public void setY(int y)
    {
        this.y = y;
    }
    public float claculateDistance(ref Point point)
    {
        float distance;
        distance = Math.Sqrt(Math.Pow(this.x - point.x, 2) + Math.Pow(this.y - point.y, 2));
        return distance;
    }
    public bool eqaulsTo(ref Point point)
    {
        return this.x == point.x && this.y == point.y;
    }
    public void Translation(int x = 0, int y = 0)
    {
        this.x += x;
        this.y += y;
    }
    public bool static linearite(Point a, Point b, Point c)
    {
        Victor AB = new Victor(a, b);
        Victor AC = new Victor(a, c);
        return Victor.determinant(AB, AC);
    }

}
