using System;
namespace SwimingMatch
{
    public class Result
    {
        bool result;
    }
    public class Shark
    {
        int sharkDistance = 1000;//鲨鱼到浮桥的距离。如果鲨鱼在你逃到浮桥之前到达你身边，它就会吃掉你。
        int sharkSpeed = 25;//它的移动速度，单位是米/秒。
        public int getsharkDistance()
        {
            return sharkDistance;
        }
        public int getsharkSpeed()
        {
            return sharkSpeed;
        }
    }

    public class man
    {
        int pontoonDistance = 600;//你需要游到安全的地方有多远，单位是米。
        int youSpeed = 10;//你能游多快，以米/秒为单位。
        public bool flash = false;//是否开启你的闪现能力
        int flashDistance = 50;//闪现能够飞跃多远
        int flashmona = 3;//闪现次数
        public int getpontoonDistance()
        {
            return pontoonDistance;
        }
        public int getyouSpeed()
        {
            return youSpeed;
        }
        public int getflashDistance()
        {
            return flashDistance;
        }
        public int getflashmona()
        {
            return flashmona;
        }
        public bool getflash()
        {
            return flash;
        }
    }

    class SwimingMatch
    {
        public void SwimingMatch1(int num1, int num2, int num3, int num4)
        {
            int Distance = num1 - num3;//你与鲨鱼间的距离
            bool dolphin; //一个布尔值，如果为真，你可以将鲨鱼的游泳速度减半，因为海豚会攻击它。
            bool over = true;//一个布尔值，检测是否结束了
            int sharkSpeed1 = 0;
            Random rd = new Random();
            while (over)
            {
                int rd1 = rd.Next(1, 3);
                if (rd1 > 1)
                {
                    dolphin = false;
                }
                else
                {
                    dolphin = true;
                }
                if (dolphin)
                {
                    sharkSpeed1 = num2 / 2;
                }
                else
                {
                    sharkSpeed1 = num2;
                }
                Distance = Distance + num4 - sharkSpeed1;
                num3 = num3 - num4;
                if (num3 < 0)
                {
                    Console.WriteLine("Alive!");
                    over = false;
                }
                if (Distance <= 0)
                {
                    Console.WriteLine("Shark Bait!");
                    over = false;
                }
                //Console.WriteLine("你与鲨鱼的距离： {0}", Distance);
            }
        }
        static void Main(string[] args)
        {
            Shark shark = new Shark();
            man m = new man();
            SwimingMatch sm = new SwimingMatch();
            //局部变量定义 
            int a = shark.getsharkDistance();
            int b = shark.getsharkSpeed();
            int c = m.getpontoonDistance();
            int d = m.getyouSpeed();
            //调用SwimingMatch方法
            sm.SwimingMatch1(a, b, c, d);
            Console.ReadLine();
        }
    }
}