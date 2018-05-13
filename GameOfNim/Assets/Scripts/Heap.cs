using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
	public class Heap
	{
		public int Amount { get { return m_amount; } }
		int m_amount = 0;

		public void Init(int size)
		{
			m_amount = size;
		}

		public void Decrease(int amount)
		{
			m_amount -= amount;
		}
	}
}
