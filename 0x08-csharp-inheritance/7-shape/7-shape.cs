using System;

class Shape
{
	/// <summary>This method throws an exception.</summary>
	public virtual int Area()
	{
		throw new NotImplementedException("Area() is not implemented");
	}
}

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

	public new int Area()
	{
		return width * height;
	}

	public override string ToString()
	{
		return $"[Rectangle] {width} / {height}";
	}
}
