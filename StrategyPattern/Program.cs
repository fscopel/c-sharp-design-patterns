using StrategyPattern;
using StrategyPattern.Strategy;


var canvas = new Canvas(new SelectionStrategy());
canvas.OnMouseDown();
canvas.OnMouseDrag();
canvas.OnMouseUp();

canvas.toolStrategy = new BrushStrategy();
canvas.OnMouseDown();
canvas.OnMouseDrag();
canvas.OnMouseUp();


Console.ReadLine();

