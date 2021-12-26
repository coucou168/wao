using System;

namespace Swiming
{
    class SwimingMatch
    {
        static int sharkDistance = 1000; //鲨鱼到浮桥的距离。如果鲨鱼在你逃到浮桥之前到达你身边，它就会吃掉你。
        static int sharkSpeed = 20; //它的移动速度，单位是米/秒。
        static int pontoonDistance = 700; //你需要游到安全的地方有多远，单位是米。
        static int youSpeed = 10; //你能游多快，以米/秒为单位。
        static int Distance = sharkDistance - pontoonDistance;//你与鲨鱼间的距离
        static bool dolphin; //一个布尔值，如果为真，你可以将鲨鱼的游泳速度减半，因为海豚会攻击它。
        static bool over = false;//一个布尔值，检测是否结束了
        static void Main(string[] args)
        {
            int sharkSpeed1 = 0；
            Random rd = new Random()；
            rd.next(1, 2)；
            while (over)
            {
                if (rd > 1)
                {
                    dolphin = false;
                }
                else
                {
                    dolphin = true;
                }
                if（dolphin）
                {
                    sharkSpeed1 = sharkSpeed / 2;
                }
                else
                {
                    sharkSpeed1 = sharkSpeed;
                }
                Distance = Distance + youspeed - sharkSpeed1;
                pontoonDistance = pontoonDistance - youSpeed;
                if (pontoonDistance < 0)
                {
                    Console.WriteLine("Alive!");
                    over = true；
                }
                if(Distance <= 0)
                {
                    Console.WriteLine("Shark Bait!");
                    over = true；
                }
                Console.WriteLine("你与鲨鱼的距离： {0}", Distance);
            }
        }
    }
}