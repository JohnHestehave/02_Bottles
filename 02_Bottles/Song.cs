using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Bottles
{
	public class Song
	{
		public string CountBottles(int b)
		{

			if (b <= 0)
			{
				return " No more bottles of beer on the wall.";
			}
			else
			{
				int d = b - 1;
				return "" + b + " bottle"+(b!=1?"s":"")+" of beer on the wall."
					+ " " + b + " bottle"+(b!=1?"s":"")+" of beer."
					+ " Take one down and pass it around."
					+ (b > 1 ? " " + d + " bottle" + (d != 1 ? "s" : "") + " of beer on the wall. " : "")
					+ CountBottles(d);
			}



			/*
			switch (b)
			{
				case 0:
					return " No more bottles of beer on the wall.";
				case 1:
					return "1 bottle of beer on the wall. 1 bottle of beer."
						+" Take one down and pass it around." 
						+ CountBottles(0);
				case 2:
					return "2 bottles of beer on the wall."
						+ " 2 bottles of beer."
						+ " Take one down and pass it around."
						+ " 1 bottle of beer on the wall. "
						+ CountBottles(1);
				case 3:
					return "3 bottles of beer on the wall."
						+ " 3 bottles of beer."
						+ " Take one down and pass it around."
						+ " 2 bottles of beer on the wall. "
						+ CountBottles(2);
				default:
					return "";
			}
			*/
		}
	}
}
