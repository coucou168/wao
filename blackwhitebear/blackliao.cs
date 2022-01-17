using System;
namespace WhiteblackbearMatch
{
	class bear
	{
		public double bX;
		public double bY;
	}
	class Seat {
		double X;
		double Y;
		public Seat(double x, double y
			) {
			X = x;
			Y = y;
		}
		public double getSeatX()
		{
			return X;
		}
		public double getSeatY()
		{
			return Y;
		}
	}
	class Node<T>
	{
		T point;
		public Node<T> next;
		public Node(T t)
		{
			point = t;
		}
		public T getValue()
		{
			return point;
		}
		public Node<T> getNext()
		{
			return next;
		}
		public void setNext(Node<T> node)
		{
			next = node;
		}
	}
	class List<T>
	{
		int count = 0;
		Node<T> head;
		Node<T> tail;
		public int Add(T t)
		{
			Node<T> theNew = new Node<T>(t);
			if (count == 0)
			{
				head = theNew;
				tail = theNew;
			}
			else
			{
				tail.next = theNew;
				tail = theNew;
			}
			count++;
			return 1;
		}
		public int getCount()
		{
			return count;
		}
		public int Remove(T t)
		{
			if (count == 0) return 0;
			if (head.getValue().Equals(t))
				if (head.next != null)
				{
					head = head.getNext();
					count--;
					return 1;
				}
				else
				{
					head = null;
					count--;
					return 1;
				}
			int i = 1;
			Node<T> node = head;
			while (i < count)
			{
				if (node.getNext().getValue().Equals(t))
				{
					node.setNext(node.getNext().getNext());
					count--;
					return 1;
				}
				node = node.getNext();
				i++;
			}
			return 0;
		}
		public Node<T> getFirst()
		{
			return head;
		}
		public Node<T> getLast()
		{
			return tail;
		}
	}
	public void bearmove
	{
		random rd = new random();
		bX = bX + rd.NextDouble(0,5);
		bY = bY + rd.NextDouble(0,5);
		Seat W = new Seat(bX, bY);
		list.Add(W);
	}
	public void eatbean()
	{
		random rd = new random();
		double EX = rd.NextDouble(0,100);
		double EY = rd.NextDouble(0,100);
		double R;
		int G = 1;
		Node<Seat> Seat = null;
		while (G <= list.getCount())
		{
			if (Seat == null)
				Seat = list.getFirst();
				if (math.sqrt((seat.X - EX) * (seat.X - EX) + (seat.Y - EY) * (seat.Y - EY)) < R)
				{
				list.Remove(Seat)
				}
			else
				Seat = Seat.getNext();
				if (math.sqrt((seat.X - EX) * (seat.X - EX) + (seat.Y - EY) * (seat.Y - EY)) < R)
				{
				list.Remove(Seat)
				}
	}
	}
	}

	class BlackWhitebearMovetest
	{
		static void Main(string[] args)
		{
			List<Seat> list = new List<Seat>();
			Seat A = new Seat(1,1);
			Seat B = new Seat(2,2);
			Seat C = new Seat(3,3);
			Seat D = new Seat(4,4);
			list.Add(A);
			list.Add(B);
			list.Add(C);
			list.Add(D);
			list.Remove(C);
			int i = 1;
			Node<Seat> Seat = null;
			while (i <= list.getCount())
			{
				if (Seat == null)
					Seat = list.getFirst();
				else
					Seat = Seat.getNext();
				Console.WriteLine(i++ + ":" + "(" + Seat.getValue().getSeatX() + "," + Seat.getValue().getSeatY() + ")");
			}
		}


	}
}
