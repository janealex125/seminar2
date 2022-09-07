// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Clear();
Console.Write("Введите число , обозначающее день недели, где 1 - понедельник, 7 - воскресенье: ");

int dayOfWeek = int.Parse(Console.ReadLine()?? "0");

if(dayOfWeek == 6 || dayOfWeek == 7)
    Console.WriteLine("День недели является выходным днем.");

else
    Console.WriteLine("День не является выходным днем.");