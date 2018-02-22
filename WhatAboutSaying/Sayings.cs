
using System;

namespace WhatAboutSaying
{

	public class Sayings
	{
		public String sayingInFinnish { get; set; }
		public String sayingInEnglish { get; set; }
		
		public Sayings(String finSay, String finEng)
		{
			sayingInFinnish = finSay;
			sayingInEnglish = finEng;
		}
		
		//Consctructor without parametrs.
		public Sayings(){}
		
		public String getFinSay()
		{
			return sayingInFinnish;
		}
		
		public String getEngSay()
		{
			return sayingInEnglish;
		}
	}
}



