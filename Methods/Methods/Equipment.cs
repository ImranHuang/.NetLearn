using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    /// <summary>
    /// 设备类
    /// </summary>
    public class Equipment
    {

        /// <summary>
        /// 构造方法不能有返回值
        /// </summary>
        public Equipment() 
        {
            //可以读取配置文件中的信息

            //也可以初始化字段或者属性

            this.EquipID = 200;
            this.EquipName = "未知";
        }






        private int _equipID = 0;
        public int EquipID
        {
            get { return _equipID; }
            set {
                if (value < 100)
                    _equipID = 100;
                else                
                _equipID = value; }
        }

        public string EquipName { get; set; } = string.Empty;
        public string EquipType { get; set; } = "KYJ-01";
        public double Pressure
        {
            get
            {
                double res = 2.5; 
                return res; 
            }
        }

        public DateTime CollectTime { get { return DateTime.Now; } }

        //当前设备有多个传感器，使用集合方式处理
        public Sensor[] SensorsArray { get; set; } = new Sensor[5];

        public List<Sensor> SensorsList { get; set; }

    }
}
