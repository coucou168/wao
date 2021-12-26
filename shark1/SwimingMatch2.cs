using System;
namespace SwimingMatch
{
	class Shark
    {
		int sharkDistance;//鲨鱼到浮桥的距离。如果鲨鱼在你逃到浮桥之前到达你身边，它就会吃掉你。
		int sharkSpeed;//它的移动速度，单位是米/秒。
		bool dolphin;//一个布尔值，为真时，鲨鱼会被海豚攻击而导致移动速度减半。
        public void setsharkDistance len)
        {
            sharkDistance = len;
        }
    }
	class Man
    {
		int pontoonDistance;//你需要游到安全的地方有多远，单位是米。
		int youSpeed;//你能游多快，以米/秒为单位。
		bool flash;//是否开启你的闪现能力
		int flashDistance;//闪现能够飞跃多远
        int flashmona;//闪现次数
	}

	class SwimingMatch
    {
		Console.WriteLine("鲨鱼吃人大赛开始");
		static void Main(string[] args)
        {
			Shark shark1 = new Shark();//声明一个鲨鱼
			Console.WriteLine("请设置鲨鱼起始距离");
			shark1.sharkDistance = Convert.ToInt32(Console.ReadLine());//
			Console.WriteLine("请设置鲨鱼移动速度");
			shark1.sharkSpeed = Convert.ToInt32(Console.ReadLine());//
            shark1.dolphin = false;

			Man man1 = new Man();//声明一个人
			Console.WriteLine("请设置你的起始距离");
			man1.pontoonDistance = Convert.ToInt32(Console.ReadLine());//
			Console.WriteLine("请设置你的移动速度");
			man1.youSpeed = Convert.ToInt32(Console.ReadLine());//
			Console.WriteLine("是否开启闪现，是输入1，否输入2");
			int flashpower = Convert.ToInt32(Console.ReadLine());//
            if (flashpower = 1)
            {
                man1.flash = true;
            }
            else
            {
                man1.flash = false;
            }
            Console.WriteLine("请设置你的闪现距离");
            man1.flashDistance = Convert.ToInt32(Console.ReadLine());//
            Console.WriteLine("请设置你的闪现次数");
            man1.flashmona = Convert.ToInt32(Console.ReadLine());//


			static int Distance = shark1.sharkDistance - man1.pontoonDistance;//你与鲨鱼间的距离
			static bool over = true;//一个布尔值，检测是否结束了
			static int Distance;//你与鲨鱼间的距离
			int sharkSpeed1 = 0;
			Random rd = new Random();
            while (over)
            {
                int rd1 = rd.Next(1, 3);
                if (rd1 > 1)
                {
                    shark1.dolphin = false;
                }
                else
                {
                    shark1.dolphin = true;
                }
                if (shark1.dolphin)
                {
                    sharkSpeed1 = shark1.sharkSpeed / 2;
                }
                else
                {
                    sharkSpeed1 = shakr1.sharkSpeed;
                }
                Distance = Distance + man1.youSpeed - shark1.sharkSpeed1;
                man1.pontoonDistance = man1.pontoonDistance - man1.youSpeed;
                if (man1.pontoonDistance < 0)
                {
                    Console.WriteLine("Alive!");
                    over = false;
                }
                if (Distance <= 0)
                {
                    if(man1.flashmona > 0)
                    {
                        man1.flashmona--;
                        Distance = Distance + man1.flashDistance;
                    }
                    else
                    {
                        Console.WriteLine("Shark Bait!");
                        over = false;
                    }
                }
                Console.WriteLine("你与鲨鱼的距离： {0}", Distance);
            }
	}
}

