                             //1-savol
//using System;
//using System.Collections.Generic;

//class EvenNumberCounter
//{
  //  static void Main(string[] args)
    //{
      //  List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //int evenCount = CountEvenNumbers(numbers);
        
       // Console.WriteLine("Listdagi juft sonlar miqdori: " + evenCount);
       // Console.WriteLine("List: [" + string.Join(", ", numbers) + "]");
   // }
   // public static int CountEvenNumbers(List<int> numbers) 
   // {
      //  int count = 0;

      //  {
            
      //  }
      //  foreach (int number in numbers)
       // {
         //   if (number % 2 == 0)
         //   {
         //       count++;
        //    }
      //  }
    //    return count;
 ///   } 
//}   

                                 //2-savol

//static bool AllLengthGreaterThanFive(List<string> list)
//{
  //  foreach (string item in list)
   // {
      //  if (item.Length <= 5)
       // {
        //    return false;
       // }
   // }
  //  return true;
//}
                                 //3-SAVOL
static string FirstThreeChars(string text)
{
    if (text.Length < 3)
    {
        return text;
    }
    return text.Substring(0, 3);
}
 

                               //4 -SAVOL

static bool StartsWithPDP(string text)
{
    return text.StartsWith("PDP");
}

                               //5-SAVOL
static bool IsG13(string text)
{
    return text == "G13";
}


