
using System;

namespace WhatAboutSaying
{
	/// <summary>
	/// Description of Sayings.
	/// </summary>
	public class Sayings
	{
		public String Name { get; set; }
		public int Age { get; set; }
		
		public Sayings(String name, int age)
		{
			Name = name;
			Age = age;
		}

		
		//Consctructor without parametrs.
		public Sayings(){}
		
		
		
		// The first paragraph of hello world test!
		public String jee()
		{
			return "Terve maailma!";
		}
		
		// Returns double number!
		public Double numero()
		{
			return 23.2342;
		}
		
		public String haHaa()
		{
			return Name;
		}
	}
}



