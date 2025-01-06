using css_souradnice;

Coord c1 = new Coord(10, 10);
Coord c2 = new Coord(10, 10);
Coord c3 = new Coord(5, 5);
Coord c4 = new Coord(2, 3);

Console.WriteLine(c1 == c2);
Console.WriteLine(c1 != c3);
Console.WriteLine(c1.Equals(c2));
Console.WriteLine(c3.Equals(c4));

Console.WriteLine(c1 > c3);
Console.WriteLine(c3 < c4);

Coord c5 = c1 + c3;
Console.WriteLine(c5);

Coord c6 = c1 * 2;
Console.WriteLine(c6);

Console.WriteLine(c1.Size);