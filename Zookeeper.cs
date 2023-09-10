using System;

namespace Zoo
{
	internal class Zookeeper
	{
		public string ZookeeperName;

		public Zookeeper(string zookeeperName)
		{
			this.ZookeeperName = zookeeperName;
		}

		public void FeedAnimals(Animal art)
		{
			Console.WriteLine($"{ZookeeperName} is feeding {art.Name}!");
		}
	}
}
