using System;
using System.Collections.Generic;
using System.Text;

namespace NumGeneratorObserver
{
	public abstract class NumberGenerator
	{
		private List<IObserver> observers = new List<IObserver>();

		public void AddObserver(IObserver observer)
		{
			observers.Add(observer);
		}

		public void DeleteObserver(IObserver observer)
		{
			observers.Remove(observer);
		}

		public void NotifyObservers()
		{
			observers.ForEach(obs => obs.Update(this));
		}

		public int Number { get; protected set; }
		public abstract void Execute();
	}
}
