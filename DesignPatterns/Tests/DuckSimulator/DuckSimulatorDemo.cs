using NUnit.Framework;
using Strategy.DuckSimulator.Implementations.Ducks;
using Strategy.DuckSimulator.Implementations.FlyBehaviors;
using Strategy.DuckSimulator.Implementations.QuackBehaviors;

namespace Tests.DuckSimulator
{
	[TestFixture]
	public class DuckSimulatorDemo
	{
		[Test]
		public void DuckSimulatorTest()
		{
			var mallardDuck = new MallardDuck(new FlyWithWings(), new Quack());
			mallardDuck.Display();
			mallardDuck.PerformFly();
			mallardDuck.PerformQuack();

			//Dynamically change behavior
			mallardDuck.ChangeFlyBehaviour(new FlyRocketPower());
			mallardDuck.PerformFly();


			Assert.True(true);
		}
	}
}