var a = 10;
var b = 20;

Console.WriteLine($"Before swap -> a = {a}, b = {b}");

var aux = a;
a = b;
b = aux;

Console.WriteLine($"After swap -> a = {a}, b = {b}");


Console.WriteLine("*****");


var w = 10;
var y = 20;

Console.WriteLine($"Before swap -> w = {w}, y = {y}");

(w, y) = (y, w);

Console.WriteLine($"After swap -> w = {w}, y = {y}");


Console.WriteLine("*****");
Console.WriteLine("*****");


var person1 = new DemoPerson { Name = "John", Age = 30 };
var person2 = new DemoPerson { Name = "Mary", Age = 25 };

Console.WriteLine($"Before swap -> person1 [{person1}], person2 [{person2}]");

var tmp = person1;
person1 = person2;
person2 = tmp;

Console.WriteLine($"After swap -> person1 [{person1}], person2 [{person2}]");


Console.WriteLine("*****");


var person3 = new DemoPerson { Name = "Chris", Age = 35 };
var person4 = new DemoPerson { Name = "Jane", Age = 40 };

Console.WriteLine($"Before swap -> person3 [{person3}], person4 [{person4}]");

(person3, person4) = (person4, person3);

Console.WriteLine($"After swap -> person3 [{person3}], person4 [{person4}]");


public class DemoPerson
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString() => $"Name = {Name}, Age = {Age}";
}
