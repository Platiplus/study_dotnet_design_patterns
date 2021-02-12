﻿namespace Visitor
{
	public class ConcreteElementA : Element
	{
		public override void Accept(Visitor visitor)
		{
			visitor.VisitConcreteElementA(this);
		}
	}
}