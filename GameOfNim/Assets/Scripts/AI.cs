using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
	/// <summary>
	/// Public getter for if the AI is active
	/// </summary>
	public bool IsActve { get { return m_isActive; } }
	bool m_isActive = false;

	Difficulty.eDifficulty m_level;

	public void Start()
	{

	}

	/// <summary>
	/// Setup the AI (I don't know what this does)
	/// </summary>
	public void Init()
	{
		m_isActive = true;
	}

	/// <summary>
	/// Gets the AI's turn based on the heaps inputted
	/// </summary>
	/// <param name="heaps"> the selection of heaps to base the AI's turn off of </param>
	/// <returns> array of ints, size 2, first is heap index and second is amount from heap </returns>
	public int[] TakeTurn(Heap[] heaps)
	{
		int[] dou = new int[2];
		int choice = -1;

		if (m_level == Difficulty.eDifficulty.MEDIUM)
		{
			if (Random.value > 0.5) choice = 0;
			else choice = 1;
		}

		if (m_level == Difficulty.eDifficulty.EASY || choice == 0)
		{
			bool valid = false;
			while (!valid)
			{
				int selection = Random.Range(0, heaps.Length - 1);
				if (heaps[selection].Amount > 0)
				{
					dou[0] = selection;
					dou[1] = Random.Range(1, heaps[selection].Amount);
					valid = true;
				}
			}
		}
		else if (m_level == Difficulty.eDifficulty.HARD || choice == 1)
		{
			string[] binary = new string[heaps.Length];

			for(int i=0;i<heaps.Length;i++)
			{
				binary[i] = System.Convert.ToString(heaps[i].Amount, 2);
			}

			string last = binary[0];
			int n = 1;
			while(n < heaps.Length)
			{
				int i = System.Convert.ToInt32(last);
				int j = System.Convert.ToInt32(binary[n]);
				last = System.Convert.ToString((i & j));
			}

			int balance = System.Convert.ToInt32(last);
			if(balance == 0)
			{

			}
		}

		return dou;
	}
}
