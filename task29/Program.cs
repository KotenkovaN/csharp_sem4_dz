﻿Console.Clear(); 
int[] array = new int[8]; 
for (int i = 0; i < 8; i++) 
{ 
          Console.Write("Введите элемент массива: "); 
          int x = Convert.ToInt32(Console.ReadLine()); 
          array[i] = x; 
} 
Console.WriteLine($"[{string.Join(", ", array)}]"); 