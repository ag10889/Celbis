using System;
namespace userDatabase
{
	public class Node
	{
		public lotInfo lot;
		public Node next;
		public Node(lotInfo lot)
		{
			this.lot = lot;
			next = null;
		}
		
	}
}

