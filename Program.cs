// //Вычисление расстояния между двумя точками в 3D пространстве.

// double dispace(double xa, double ya, double za, double xb, double yb, double zb)
// {
//   return Math.Round(Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2) + Math.Pow(za - zb), 2));      
// }
// Console.WriteLine("Input coordinata x to A");
// double xa = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinata y to A");
// double ya = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinata z to A");
// double za = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinata x to B");
// double xb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinata y to B");
// double yb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinata z to B");
// double zb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Distance between point A({xa},{ya},{za}) and B({xb},{yb},{zb}) in spece -> {dispace(xa,ya,xb,yb,za,zb)}");


// // Возведения в куб последовательно всех чисел от 1 до N с выводом значений.

// Console.WriteLine("Input N");
// int namber=Convert.ToInt32(Console.ReadLine());
//     int i=1;
//     while(i<=namber)
//     {
//         Console.WriteLine($"{i} -> {i*i*i}");
//         i++;

// Проверка 5-ти значного числа на полиндром

Console.WriteLine("Input namber ");
string namber=Convert.ToString(Console.ReadLine());
int Col=namber.Length;
if (Col==5)
{
    if (namber[0] == namber[4] &&  namber[1] == namber[3])
    {
        Console.WriteLine($"{ namber} - Polindrom");
    }
    else
    {
        Console.WriteLine($" {namber} - No Polindrom" );
    }
}
 else
 {
    Console.WriteLine($"{namber} - Inpur error");
 }
    

