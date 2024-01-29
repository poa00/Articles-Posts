using CSharp9RecordPatternMatchingExamples.PatternMatching;
using CSharp9RecordPatternMatchingExamples.PatternMatching.Models;
using static CSharp9RecordPatternMatchingExamples.Data;

//Value Equality
var person1 = new Person("John", "Doe");
var person2 = new Person("John", "Doe");

if (person1 == person2)
{
    Console.WriteLine("Both persons are equal.");
}


//Deconstruction
var person = new Person("Jane", "Doe");
var (firstName, lastName) = person;
Console.WriteLine($"First Name: {firstName}, Last Name: {lastName}");


//Type Patterns
string strExample = "I am Ziggy Rafiq!";
int intExample = 32;
DateTime dateTimeExample = DateTime.Now;
double doubleExample = 3.14;
bool boolExample = true;

Console.WriteLine(GetDisplayText(strExample));
Console.WriteLine(GetDisplayText(intExample));
Console.WriteLine(GetDisplayText(dateTimeExample));
Console.WriteLine(GetDisplayText(doubleExample));
Console.WriteLine(GetDisplayText(boolExample));


//Property Patterns

// Example 1: Point
Shape point = new Shape { Width = 0, Height = 0 };
Console.WriteLine(ShapeInfo.GetShapeDescription(point));  // Output: Point

// Example 2: Square
Shape square = new Shape { Width = 5, Height = 5 };
Console.WriteLine(ShapeInfo.GetShapeDescription(square));  // Output: Square with side 5

// Example 3: Rectangle
Shape rectangle = new Shape { Width = 3, Height = 7 };
Console.WriteLine(ShapeInfo.GetShapeDescription(rectangle));  // Output: Rectangle with width 3 and height 7

// Example 4: Unknown Shape
Shape unknownShape = new Shape { Width = 2, Height = 4 };
Console.WriteLine(ShapeInfo.GetShapeDescription(unknownShape));  // Output: Unknown Shape