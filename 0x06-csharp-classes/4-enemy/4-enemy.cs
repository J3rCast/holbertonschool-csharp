using System;

namespace Enemies
{
	/// <summary>
	/// Empty class with a default constructor
	/// </summary>
	public class Zombie
	{
		/// <summary>Fields.</summary>
		public int health;
		private string name = "(No name)";

		/// <summary>Initializes a new instances of the <see cref="Zombie"/> class.</summary>
		public Zombie()
		{
			health = 0;
		}

		/// <summary>Initializes a new instance of the <see cref="Zombie"/> class
		/// allowing using arguments.</summary>
		public Zombie(int value)
		{
			if (value < 0)
				throw new ArgumentException("Health must be greater than or equal to 0");
			health = value;
		}

		/// <summary>Get health of the <see cref="Zombie"/>.</summary>
		/// <returns>The health of the <see cref="Zombie"/>.</returns>
		public int GetHealth()
		{
			return health;
		}

		/// <summary>Propery for name.</summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
	}
}
