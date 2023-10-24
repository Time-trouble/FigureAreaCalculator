using CalculationAreaLib;

// создание круга и получение его площади
var radius = 5;
Figure circle = new Circle(radius);

var circleArea = circle.GetArea();

Console.WriteLine($"Площадь круга: {circleArea}");

// создание треугшольника, получение его площади и проверка треугольника является ли он прямоугольным 
double a = 3;
double b = 4;
double c = 5;
Figure triangle = new Triangle(a, b, c);

var triangleArea = triangle.GetArea();
var isRightTriangle = (triangle as Triangle)?.IstRiangleRectangular() ?? false;

Console.WriteLine($"Площадь треугольника: {triangleArea}");
Console.WriteLine($"Прямоугольный треугольник: {isRightTriangle}");



