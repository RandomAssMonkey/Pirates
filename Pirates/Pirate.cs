using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
	internal class Pirate
	{
		private string crewmate;
		private int toxicated;

		public string Crewmate { get => crewmate; set => crewmate = value; }
		public int Toxicated { get => toxicated; set => toxicated = value; }

		public Pirate(string crewmate)
		{
			this.crewmate = crewmate;
			this.toxicated = 0;
		}

		public int drinkSomeRum()
		{
			this.toxicated++;
			return this.toxicated;
		}

		public int GetToxicated()
		{
			return toxicated;
		}

		public string howItsGoingMate()
		{
			if (this.toxicated >= 4)
			{
				this.Toxicated = 0;
				return "Passes out";
			}
			else
			{
				return "Pour me anudder!";
			}
		}




	}
}
