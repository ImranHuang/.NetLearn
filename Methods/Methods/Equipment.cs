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

        /// <summary>
        /// 重载
        /// </summary>
        /// <param name="_equipID"></param>
        /// <param name="equipName"></param>
        public Equipment(int _equipID,string equipName)
        {
            this._equipID = _equipID;
            this.EquipName = equipName;
        }

        /// <summary>
        /// 方法重载
        /// 先调用this里面的
        /// </summary>
        /// <param name="_equipID"></param>
        /// <param name="equipName"></param>
        /// <param name="equipType"></param>
        public Equipment(int _equipID, string equipName,string equipType):this(_equipID, equipName)
        {            
            this.EquipType = equipType;
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



        /// <summary>
        /// 无参数无返回值方法
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine($"设备ID：{EquipID}设备名称："+$"{EquipName}压力：{Pressure}采集时间：{CollectTime}");
        }

        public void ShowInfo(string name,double pressure)
        {
            Console.WriteLine($"设备ID：{EquipID}设备名称：" + $"{name}压力：{pressure}采集时间：{CollectTime}");
        }

        public string GetInfo(string name, double pressure)
        {
          string result=$"设备ID：{EquipID}设备名称：" + $"{name}压力：{pressure}采集时间：{CollectTime}";
            return result;
        }


        /// <summary>
        /// 返回传感器对象
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Sensor GetSensor(int index)
        {
            return this.SensorsArray[index];
        }


        public Sensor[] GetSensors(double temeperature)
        {
            return this.SensorsArray.Where(s => s.Temperature > temeperature).ToArray();//大于指定温度的传感器存入数组中

        }



    }
}
