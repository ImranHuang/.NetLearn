using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstClass
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Console.Write("请输入你的姓名：");
            //string name = Console.ReadLine();
            //Console.Write("请输入你报名的课程：");
            //string course = Console.ReadLine();
            //Console.WriteLine($"{name} 报了 {course}");

            //string info = string.Format("{0} 报了 {1}", name, course);
            //Console.WriteLine(info);



            Test(); 

            Console.ReadLine();

        }

        /// <summary>
        /// 字符串分割
        /// </summary>
        public static void Test()
        {
            string data = "29.0,26.3,27.5,28.7";
            //字符串分割
            string[] dataList=  data.Split(',');
            foreach (var item in dataList)
            {
                Console.WriteLine(item);
            }


            //字符合并
            string newData = string.Join("_", dataList);

            Console.WriteLine(newData);
        }


    }
}
  