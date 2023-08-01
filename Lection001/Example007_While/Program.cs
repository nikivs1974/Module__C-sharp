Console.Clear();
Console.SetCursorPosition(0,0);
Console.WriteLine("+");
int positionX = 0;
int positionY = 0;
while (positionX <= 10) {
    Console.SetCursorPosition(positionX,0);
    Console.WriteLine("+");
    Console.SetCursorPosition(positionX,10);
    Console.WriteLine("+");
    Console.SetCursorPosition(0,positionY);
    Console.WriteLine("+");
    Console.SetCursorPosition(10,positionY);
    Console.WriteLine("+");
    positionX +=1;
    positionY +=1;
}

