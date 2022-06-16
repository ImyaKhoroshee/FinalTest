string[] FormNewArray (string[] arg)
{
   int short_count = 0;
   // переменная для подсчета длины нового массива
   for (int i = 0; i < arg.Length; i++)
   {
      if(arg[i].Length <= 3)
      short_count++;
   }

   string[] formedarray = new string[short_count];
   // инициализация 2-го массива с длиной, которую выше определили
   Console.Write($"New formed array is: [");
   
   int j = 0;
   for (int i = 0; i < arg.Length; i++)
   {
      if(arg[i].Length <= 3) // проверка по заданному условию
      {
         formedarray[j] = arg[i]; // присвоение подходящего элемента
         Console.Write($"{formedarray[j]}");
         j++; // увеличение индекса у второго массива
      }
   }
   Console.Write($"]");
   return formedarray;
}  
string[] initialarray = {"Res", "ult", "FinalTest", ": ", "Tatyana", "decision", "Павел", "5ka", " ", ":D!"};
//string[] initialarray = {"hello", "2", "world", ":-)"};   for test
//string[] initialarray = {"Russia", "Denmark", "Kazan"};   for test
FormNewArray (initialarray); 