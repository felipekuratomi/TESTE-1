﻿using System;

namespace TaskExceptionsDemo
{
	public class MyException : Exception
	{
		public MyException(string message)
			: base(message)
		{

		}
	}
}
