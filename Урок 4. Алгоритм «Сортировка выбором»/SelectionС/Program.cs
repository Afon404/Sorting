// using static Sorting;

// // using static System.Console;  Если добавить эту строку то можно тогда убрать из строк System;  

//  int[] array = {22, 34, 5, 6, 77, 85, 2, 4, 5, 3, 2, 9};    // Создаём массив

// System.Console.WriteLine($"[{String.Join(" ,", array)}]"); //Показываем массив
// SortSelection(array);
// System.Console.WriteLine($"[{String.Join(" ,", array)}]");  // Сортируем массив


////////////////Способ 2:

using static Sorting;
using static Infrastructure;

10.CreateArray(min: 10, max: 30)
  .Show("| ")
  .SortSelection()
  .Show("}, {");
Console.ReadLine();



  /////Способ 3 


// int[] ar = 10.CreateArray(min: 10, max: 30);   //  Заполняем массив
// ar.Show();                                    // Показываем его
// ar.SortSelection();                         //  Сотрируем в Файле Sorting
// ar.Show();                                  // И показываем отсортировачный массив