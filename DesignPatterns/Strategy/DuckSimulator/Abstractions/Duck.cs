using System;
using Strategy.DuckSimulator.Abstractions.Behaviors;

namespace Strategy.DuckSimulator.Abstractions
{
	public abstract class Duck
	{
		//Behavior that can change is encapsulated.
		private IFlyBehaviour _flyBehaviour;
		private IQuackBehaviour _quackBehaviour;

		protected Duck(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour)
		{
			this._flyBehaviour = flyBehaviour;
			this._quackBehaviour = quackBehaviour;
		}

		public void ChangeFlyBehaviour(IFlyBehaviour flyBehaviour)
		{
			_flyBehaviour = flyBehaviour;
		}

		public void ChangeQuackBehavior(IQuackBehaviour quackBehaviour)
		{
			_quackBehaviour = quackBehaviour;
		}

		public abstract void Display();

		public void PerformQuack()
		{
			_quackBehaviour.Quack();
		}

		public void PerformFly()
		{
			_flyBehaviour.Fly();
		}


		public void Swim()
		{
			Console.WriteLine("I am duck and I am swimming!");
		}
	}
}