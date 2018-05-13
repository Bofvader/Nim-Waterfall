using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
	public class Heap
	{
		/// <summary>
		/// Public getter for the amount in a heap
		/// </summary>
		public int Amount { get { return m_amount; } }
		int m_amount = 0;

		/// <summary>
		/// Set the size of the heap
		/// Should be called during creation of a heap object
		/// </summary>
		/// <param name="size"> size of the heap </param>
		public void Init(int size)
		{
			m_amount = size;
		}

		/// <summary>
		/// Decrease the amount in a heap
		/// </summary>
		/// <param name="amount"> the amount taken from the heap</param>
		public void Decrease(int amount)
		{
			m_amount -= amount;
		}
	}
}
