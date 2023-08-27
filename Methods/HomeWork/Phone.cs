using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    /// <summary>
    /// 手机类
    /// </summary>
    public class Phone
    {
        //手机需要记录的内容
        //品牌，颜色，价格，硬盘，内存，处理器，类型，屏幕
        //功能：打电话，发短线，玩游戏，看电影

        public Phone() { }
        public Phone(Brand brand, Color color, double price)
        {
            this.PhoneBrand = brand;
            this.PhoneColor = color;
            this.Price = price;
             
        }
        public Phone(Brand brand, double price, Color color=Color.Black, int memory=6):this(brand,color,price)
        {    
            this.Memory = memory;
        }
        public Brand PhoneBrand { get; }
        public Color  PhoneColor { get; }

        public double Price { get; set; }
        public int ScreenSize { get;  }
        public int Memory { get;  }

        public DateTime PulishDate { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"手机品牌：{PhoneBrand} 内存：{Memory} 手机颜色：{PhoneColor}");
        }


        public bool Call(string num)
        {
            Console.WriteLine("正在拨打电话........."+num);
            Console.WriteLine("通话中......");
            Console.WriteLine(  "通话结束.......");

            return true;

        }

        public void SendMsg(string num, string connect)
        {


        }







    }

    /// <summary>
    /// 手机品牌枚举
    /// </summary>
    public enum Brand
    {
        HuaWei=0,
        Xiaomi=1,
        Oppo=2,
        Vivo=3,
        Apple=4,
        Samsung=5
    }

    public enum Color
    {
        Blue=0,
        White=1,
        Black=2,
        Red=3

    }






}
