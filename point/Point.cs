using System;
using Victor;
public class Point
{
    private float x;
    private float y;
    public Point()
    {
        this.x = 0;
        this.y = 0;
    }
    public Point(float x, float y)
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
        return (this.x == point.x) && (this.y == point.y);
    }
    public Point Translation(float x = 0, float y = 0)
    {
        this.x += x;
        this.y += y;
        return this;
    }
    public bool static linearite(Point b, Point c)
    {
        float determinant = (b.getX - this.getX) * (c.getY - this.getY) - (c.getX - this.getX) * (b.getY - this.getY);
        return determinant == 0;
    }

}
