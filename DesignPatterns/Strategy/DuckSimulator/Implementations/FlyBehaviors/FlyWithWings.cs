using System;
using Strategy.DuckSimulator.Abstractions.Behaviors;

namespace Strategy.DuckSimulator.Implementations.FlyBehaviors
{
	public class FlyWithWings : IFlyBehaviour
	{
		public void Fly()
		{
			Console.WriteLine("I am duck and I can fly with my wings!");
		}
	}
}