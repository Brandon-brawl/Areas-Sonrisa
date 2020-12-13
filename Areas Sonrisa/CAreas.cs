using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas_Sonrisa
{
    class CAreas
    {
    
        public static decimal Cuadrado(decimal lado)
        {
            return lado * lado;
            //return area;
        }
        public static decimal Triangulo(decimal b, decimal h)
        {
           return (b * h) / 2;
            //return area;
        }
        public static decimal Rectanguo(decimal b, decimal h)
        {
            return (b * h);
            //return area;
        }
        public static decimal Trapecio(decimal B, decimal b, decimal h)
        {
            return h * (B + b) / 2;
            //return area;
        }
        public static decimal Circulo(decimal r)
        {
            return (decimal)(Math.PI * Math.Pow((double)r, 2));
            
        }
        public static decimal Rombo(decimal D, decimal d)
        {
           return D * d / 2;
            //return area;
        }
        public static decimal Romboide(decimal b, decimal h)
        {
            return (b * h);
            //return area;
        }
        public static decimal Pentagono(decimal p, decimal a)
        {
            return p * a / 2;
            //return area;
        }
    }
    }