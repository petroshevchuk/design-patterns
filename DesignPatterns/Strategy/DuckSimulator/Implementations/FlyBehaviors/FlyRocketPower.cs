using System;
using Strategy.DuckSimulator.Abstractions.Behaviors;

namespace Strategy.DuckSimulator.Implementations.FlyBehaviors
{
	public class FlyRocketPower : IFlyBehaviour
	{
		public void Fly()
		{
			Console.WriteLine("I'm flying with the rocket!");
		}
	}
}