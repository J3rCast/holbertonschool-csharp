using System;

/// <summary>This class contains multiple methods related to shape.</summary>
class Shape
{
	/// <summary>This method throws an exception.</summary>
	public virtual int Area()
	{
		throw new NotImplementedException("Area() is not implemented");
	}
}

/// <summary>class Rectangle that inherits from Shape.</summary>
class Rectangle : Shape
{
	private int width;
	private int height;

	public int Width
	{
		get { return width; }
		set { width = value < 0 ? throw new ArgumentException("Width must be greater than or equal to 0") : value;}
	}

	public int Height
	{
		get { return height; }
		set { height = value < 0 ? throw new ArgumentException("Height must be greater than or equal to 0") : value;}
	}

	/// <summary>This method overrides Area method of Shape.</summary>
	public new int Area()
	{
		return width * height;
	}

	/// <summary>This method overrides ToString method.</summary>
	public override string ToString()
	{
		return $"[Rectangle] {width} / {height}";
	}
}

/// <summary>class Square that inherits from Shape.</summary>
class Square : Rectangle
{
	private int size;

	public int Size
	{
		get { return size; }
		set 
		{
			if (value < 0)
				throw new ArgumentException("Size must be greater than or equal to 0");

			size = value;
			this.Width = size;
			this.Height = size;
		}
	}
}
