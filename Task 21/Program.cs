// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void ShowDistance(int xa, int xb, int ya, int yb, int za, int zb)
{
    double distance = Math.Sqrt(Math.Pow(xa-xb, 2) + Math.Pow(ya-yb, 2) + Math.Pow(za-zb, 2));
    double correction = (Math.Round(distance, 2) - Math.Round(distance, 0,MidpointRounding.ToZero))*100; //Просто решил точку сделать вместо запятой, как в ответе :)
    Console.WriteLine($"A ({xa},{ya},{za}); B ({xb},{yb},{zb}) -> {Math.Round(distance, 0,MidpointRounding.ToZero)}.{Math.Round(correction, 0,MidpointRounding.ToEven)}");
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int xa = GetInput("Введите координату X точки A: ");
int ya = GetInput("Введите координату Y точки A: ");
int za = GetInput("Введите координату Z точки A: ");
int xb = GetInput("Введите координату X точки B: ");
int yb = GetInput("Введите координату Y точки B: ");
int zb = GetInput("Введите координату Z точки B: ");
ShowDistance(xa,xb,ya,yb,za,zb);