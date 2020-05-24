using System;
using Strategy.DuckSimulator.Abstractions.Behaviors;

namespace Strategy.DuckSimulator.Implementations.QuackBehaviors
{
	public class Squeak : IQuackBehaviour
	{
		public void Quack()
		{
			Console.WriteLine("Squeak");
		}
	}
}