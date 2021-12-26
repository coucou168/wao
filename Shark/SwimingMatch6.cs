using System;
namespace SwimingMatch
{
    public class Result
    {
        public bool result;
    }
    public class Shark
    {
        public int sharkDistance = 1000;//鲨鱼到浮桥的距离。如果鲨鱼在你逃到浮桥之前到达你身边，它就会吃掉你。
        public int sharkSpeed = 25;//它的移动速度，单位是米/秒。
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
        public int pontoonDistance = 600;//你需要游到安全的地方有多远，单位是米。
        public int youSpeed = 10;//你能游多快，以米/秒为单位。
        public bool flash = false;//是否开启你的闪现能力
        public int flashDistance = 50;//闪现能够飞跃多远
        public int flashmona = 3;//闪现次数
        public bool alive = true;//存活
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
        public bool changealive()
        {
            alive = false;
            return alive;
        }
    }

    class SwimingMatch
    {
        public void SwimingMatch1(Shark unit1, man unit2)
        {
            Result result = new Result();
            int Distance = unit1.sharkDistance - unit2.pontoonDistance;//你与鲨鱼间的距离
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
                    sharkSpeed1 = unit1.sharkSpeed / 2;
                }
                else
                {
                    sharkSpeed1 = unit1.sharkSpeed;
                }
                Distance = Distance + unit2.youSpeed - sharkSpeed1;
                unit2.pontoonDistance = unit2.pontoonDistance - unit2.youSpeed;
                if (unit2.pontoonDistance < 0)
                {
                    Console.WriteLine("Alive!");
                    over = false;
                    result.result = true;
                }
                if (Distance <= 0)
                {
                    Console.WriteLine("Shark Bait!");
                    over = false;
                    result.result = false;
                    unit2.alive = false;
                }
                //Console.WriteLine("你与鲨鱼的距离： {0}", Distance);
            }
        }
        static void Main(string[] args)
        {
            Shark shark = new Shark();
            man man = new man();
            SwimingMatch sm = new SwimingMatch();
            //调用SwimingMatch方法
            sm.SwimingMatch1(shark, man);
            Console.WriteLine(man.alive.ToString());
            Console.ReadLine();
        }
    }
}