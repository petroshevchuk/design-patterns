using System;
using Strategy.DuckSimulator.Abstractions.Behaviors;

namespace Strategy.DuckSimulator.Implementations.QuackBehaviors
{
	public class MuteQuack : IQuackBehaviour
	{
		public void Quack()
		{
			Console.WriteLine("I can't quack :(");
		}
	}
}