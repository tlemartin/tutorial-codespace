var pt = (X: 1, Y: 6);

var slope = (double)pt.Y / (double)pt.X;
Console.WriteLine($"A line from the origin to the point {pt} has a slope of {slope}.");

pt.X = pt.X + 5;
Console.WriteLine($"The point is now at {pt}.");

var pt2 = pt with { Y = 10 };
pt2.X += 5;
Console.WriteLine($"The point 'pt2' is at {pt2}.");

var subscript = (A: 0, B: 0);
subscript = pt2;
Console.WriteLine(subscript);



Point pt3 = new Point(1, 1);
var pt4 = pt3 with { Y = 10 };
double slopeResult = pt4.Slope();
Console.WriteLine($"The slope of {pt4} is {slopeResult}");

Console.WriteLine($"The two points are {pt3} and {pt4}");

public record struct Point(int X, int Y){
    public double Slope() => (double)Y / (double)X;
}