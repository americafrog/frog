using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_hmh
{
    internal class Shape
    {
        protected string name;
        private string discripition;

        public string Discripition
        {
            get { return discripition; }
            set
            {
                if (value.Length < 100)
                {
                    this.discripition = value;
                }
                else
                {
                    Console.WriteLine("请输入长度为100以内的字符");
                }
            }
        }
        public Shape(string name, string discripition)
        {
            this.name = name;
            Discripition = discripition;
            
        }
        public virtual void ShowInfo() {
            Console.WriteLine("我是一个{0}",name);
        
        }
    }
}
