﻿using System;
using System.Text;

namespace _01.Person
{
	public class Person
	{
		private string name;
		private int age;

		public Person(string name, int age)
		{
			this.Name = name;
			this.Age = age;
		}

		public string Name
		{
			get { return this.name; }
			set { this.name = value; }
		}

		public int Age
		{
			get { return this.age; }
			set { this.age = value; }
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(String.Format("Name: {0}, Age: {1}", this.Name, this.Age));
			return stringBuilder.ToString();
		}
	}

	public class Child : Person
	{
		public Child(string name, int age) : base(name, age)
		{
		}
	}
}
