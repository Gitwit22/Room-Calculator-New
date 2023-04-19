
Console.WriteLine("What is the length of the property?");
string input = Console.ReadLine();
double length = double.Parse(input);

Console.WriteLine("What is the width of the property?");
input = Console.ReadLine();
double width = double.Parse(input);

Console.WriteLine("What is the height of the room?");
input = Console.ReadLine();
double height = double.Parse(input);
Console.WriteLine(" ");

double area = width * length;
double perimeter = (length * 2 + width) * 2;
double volume = length * width * height;
double surfaceArea = 6 * area;

Console.WriteLine($"The area for this room is {area}ft. ");
Console.WriteLine(" ");
Console.WriteLine($"The perimeter for this room is {perimeter}ft. ");
Console.WriteLine(" ");

string room = " ";
if (area <= 250)
{
    room = "small";
}
else if (area >= 250 && area <= 650)
{
    room = "medium";
}
else if (area > 650)
    {
    room = "large";
}


Console.WriteLine($"The volume of this room is {volume}ft.");
Console.WriteLine(" ");
Console.WriteLine($"The surface area is {surfaceArea}ft squared.");
Console.WriteLine(" ");
Console.WriteLine($"The size of this room is {room}.");
Console.WriteLine(" ");

Console.WriteLine("Thank you for using the Room Detail Generator!");











