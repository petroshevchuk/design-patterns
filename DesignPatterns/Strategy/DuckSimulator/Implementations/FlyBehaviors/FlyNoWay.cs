using System;
using Strategy.DuckSimulator.Abstractions.Behaviors;

namespace Strategy.DuckSimulator.Implementations.FlyBehaviors
{
	public class FlyNoWay : IFlyBehaviour
	{
		public void Fly()
		{
			Console.WriteLine("I am not real duck and I can't fly :(");
		}
	}
}