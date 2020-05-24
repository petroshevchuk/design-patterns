using System;
using Strategy.DuckSimulator.Abstractions.Behaviors;

namespace Strategy.DuckSimulator.Implementations.QuackBehaviors
{
	public class Quack : IQuackBehaviour
	{
		void IQuackBehaviour.Quack()
		{
			Console.WriteLine("Quuaaaaack");
		}
	}
}