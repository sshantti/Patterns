using System;
using Behavioral.Visitor;
using Behavioral.ChainOfResponsibility;
using Behavioral.Observer;

// Блок настройки входных данных
const double sphereRadius = 5.0;
const double parallelepipedWidth = 2.0;
const double parallelepipedHeight = 3.0;
const double parallelepipedLength = 4.0;
const double torusMajorRadius = 10.0;
const double torusMinorRadius = 2.0;
const double cubeSide = 3.0;

const double maxValidationLimit = 100.0;
const double invalidNegativeRadius = -5.0;
const double invalidHugeSide = 150.0;
const double validWidth = 10.0;

const int initialCarSpeed = 0;
const int updatedSedanSpeed = 60;
const int updatedSuvSpeed = 120;
// 

Console.WriteLine("=== Задание 1: Visitor (Расчет объема фигур) ===");
var shapes = new IShape[]
{
    new Sphere(sphereRadius),
    new Parallelepiped(parallelepipedWidth, parallelepipedHeight, parallelepipedLength),
    new Torus(torusMajorRadius, torusMinorRadius),
    new Cube(cubeSide)
};

var volumeVisitor = new VolumeVisitor();
foreach (var shape in shapes)
{
    shape.Accept(volumeVisitor);
}
Console.WriteLine($"Общий объем всех фигур: {volumeVisitor.TotalVolume:F2}\n");


Console.WriteLine("=== Задание 2: Chain of Responsibility (Валидация) ===");
var positiveCheck = new PositiveValueHandler();
var maxCheck = new MaxLengthHandler(maxValidationLimit);
positiveCheck.SetNext(maxCheck);

Console.WriteLine("Тест 1 (Отрицательный радиус):");    
positiveCheck.HandleRequest(invalidNegativeRadius, nameof(Sphere.Radius));

Console.WriteLine("Тест 2 (Слишком большая сторона):");
positiveCheck.HandleRequest(invalidHugeSide, nameof(Cube.Side));

Console.WriteLine("Тест 3 (Корректное значение):");
bool isValid = positiveCheck.HandleRequest(validWidth, nameof(Parallelepiped.Width));
if (isValid) Console.WriteLine("Валидация успешно пройдена!\n");


Console.WriteLine("=== Задание 3: Observer (Container и Cars) ===");
var carContainer = new Container();

var sedan = new Sedan("Toyota Camry", initialCarSpeed, "Black");
var suv = new SUV("Land Cruiser", initialCarSpeed, "White");

carContainer.AddCar(sedan);
carContainer.AddCar(suv);

Console.WriteLine("\n-- Начинаем изменять свойства авто --");
sedan.Speed = updatedSedanSpeed;
sedan.Color = "Red";
suv.Speed = updatedSuvSpeed;