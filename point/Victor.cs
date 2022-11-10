using System;
using Point

public class Victor
    {    
        private int extremity1;
        private int extremity2;
	    public Victor()
	    {
	    }
	    public Victor(Point p1, Point p2)
        {
            this.extremity1 = p2.getX - p1.getX;
            this.extremity2 = p2.getY - p1.getY;
        }
        public int getExtremity1()
        {
            return extremity1;
        }
        public int getExtremity2()
        {
            return extremity2;
        }
        public void setExtremity1(int x)
        {
            this.extremity1 = x;
        }
        public void setExtremity2(int y)
        {
            this.extremity1 = y;
        }
        public static bool  determinant(Victor v1 , Victor v2)
        {
            if(v1.getExtremity1() * v2.getExtremity2() - v1.getExtremity2() * v2.getExtremity1() == 0)
                return true;
            else
                return false;
        }
    }