using System;
using System.Collections.Generic;

namespace Coins
{
	internal class Program
	{
		static int[] coins = { 5, 10, 20, 50, 100 };
		static int C_Deposit = 32;
		static void Main(string[] args)
		{
			var ss= new List<int>();
			for (int i = 0; i < coins.Length; i++)
			{
				int CurrentCoin = coins[coins.Length - i-1];
				int LastCoin = coins[coins.Length - 1];
				while (C_Deposit>2* LastCoin)
				{
					ss.Add(LastCoin);
					C_Deposit = C_Deposit - LastCoin;
				}
				
				int remainder = C_Deposit % CurrentCoin;
				if (remainder == 0)
				{
					ss.Add(CurrentCoin);
					break;
				}
		
				if (remainder == C_Deposit)
					continue;
				if (remainder > 1)
				{
					C_Deposit=remainder;
					ss.Add(CurrentCoin);
				}
			}
			foreach (var item in ss)
			{
				Console.WriteLine(item);
			}
			Console.ReadLine();
		}
	}
}
