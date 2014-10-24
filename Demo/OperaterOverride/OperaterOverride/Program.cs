using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaterOverride
{
    class Program
    {
        static void Main(string[] args)
        {

              Vector vect1, vect2, vect3;
          vect1 = new Vector(3.0, 3.0, 1.0);
            vect2 = new Vector(2.0, -4.0, -4.0);
            vect3 = vect1 + vect2;

          Console.WriteLine("vect1=" + vect1.ToString());
          Console.WriteLine("vect2=" + vect2.ToString());
           Console.WriteLine("vect3=" + vect3.ToString());

           Console.WriteLine(2* vect2);
           Console.ReadLine();
        
        }


        struct Vector
        {
            public double x, y, z;
            public Vector(double x, double y, double z)
            {
                this.x = x;

                this.y = y;

                this.z = z;
            }


              public Vector(Vector rhs)
         
                 {
                    this.x = rhs.x;
                   this.y = rhs.y;
                     this.z = rhs.z;
                 }

              public override string ToString()
              {
                  return "(" + x + "," + y + "," + z + ")";
              }
            public static Vector operator +(Vector lhs,Vector rhs)
            {
                Vector result = new Vector(lhs);
                result.x += rhs.x;
                result.y += rhs.y;
                result.z += rhs.z;
                return result;
            }

             public static Vector operator  *(double lhs, Vector rhs)
        {
             return new Vector(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
       }

             }
    }
}
