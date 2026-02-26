using System;
using System.Threading;
Rectangle[] recs =
{
    new Rectangle { Width = 10, Height = 5},
    new Rectangle { Width = 7, Height = 7},
    new Rectangle {},
};
int count = 0;
foreach (Rectangle c in recs)
{
    count++;
    Console.WriteLine($"=== 사각형{count} ===");
    Console.WriteLine($"가로:{c.Width}, 세로: {c.Height}");
    Console.WriteLine($"넓이: {c.Area}");
    Console.WriteLine($"둘레: {c.Perimeter}");
    Console.WriteLine($"정사각형: {c.IsSquare}");
}





class Rectangle
{
    public int Width { get; set; } = 1;
    public int Height { get; set; } = 1;

    public int Area => Width * Height;
    public int Perimeter => 2 * (Width + Height);
    public bool IsSquare => Width == Height;
}