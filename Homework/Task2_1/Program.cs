
Point point1 = new Point(3, 4, 5, 10);
Point point2 = new Point(0, 0, 0, -5);
Console.WriteLine($"Point 1: X={point1.X}, Y={point1.Y}, Z={point1.Z}, Mass={point1.Mass}");
Console.WriteLine($"Point 2: X={point2.X}, Y={point2.Y}, Z={point2.Z}, Mass={point2.Mass}");
Console.WriteLine($"Point 1 IsZero: {point1.IsZero()}");
Console.WriteLine($"Point 2 IsZero: {point2.IsZero()}");

double distance = point1.DistanceTo(point2);
Console.WriteLine($"Distance between Point 1 and Point 2: {distance}");