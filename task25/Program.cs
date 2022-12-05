Console.Clear(); 
Console.Write("Ведите число A: "); 
int A = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Ведите число B: "); 
int B = Convert.ToInt32(Console.ReadLine()), result = 1;
for (int i = 1 ; i <= B; i++)
result = (A * A) ;
Console.Write($" Результат: {result} ");
