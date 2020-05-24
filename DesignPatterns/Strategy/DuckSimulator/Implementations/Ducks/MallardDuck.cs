using System;
using Strategy.DuckSimulator.Abstractions;
using Strategy.DuckSimulator.Abstractions.Behaviors;

namespace Strategy.DuckSimulator.Implementations.Ducks
{
	public class MallardDuck : Duck
	{
		public MallardDuck(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour) : base(flyBehaviour, quackBehaviour)
		{
		}

		public override void Display()
		{
			Console.WriteLine("I am Mallard Duck!!!");
		}
	}
}