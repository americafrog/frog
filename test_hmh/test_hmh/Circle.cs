using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_hmh
{
    internal class Circle:Shape
    {
     public int Radius {  get; set; }
    public static int Count {  get; set; }

        public Circle(string n,string d,int r)
            : base(n, d) { 
         Radius = r;
            Count++;
        
        }
      

            
        public override void ShowInfo()
        {
            Console.WriteLine("我是一个半径为{0}的{1}",Radius,name);
        }

    }
}
