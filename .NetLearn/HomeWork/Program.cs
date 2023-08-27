using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Phone myphone = new Phone(Brand.HuaWei, 5999.00);//手机类中有初始值
            //对象初始化器
            Phone myphone1 = new Phone(Brand.Xiaomi, 1999.00)
            {
                PulishDate = Convert.ToDateTime("2019-10-10")
            };






        }





    }
}
