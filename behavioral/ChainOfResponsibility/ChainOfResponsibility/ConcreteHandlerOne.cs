﻿using System;

namespace ChainOfResponsibility
{
	public class ConcreteHandlerOne : Handler
	{
		public override void HandleRequest(int request)
		{
			if (request >= 0 && request < 10)
			{
				Console.WriteLine($"{GetType().Name} handled request {request}");
			}
			else if (Successor != null)
			{
				Successor.HandleRequest(request);
			}
		}
	}
}
