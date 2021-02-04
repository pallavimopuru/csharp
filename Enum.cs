using System;

namespace Enum {
   class freshers {
      //static void Main(string[] args) {
          enum Categories
{
    Electronics = 1,  
    Food = 5, 
    Automotive = 6, 
    Arts = 10, 
    BeautyCare = 11, 
    Fashion = 15,
    WomanFashion = 15
}
public static void Main(){
Console.WriteLine(Categories.Fashion); //fashion
int day = (int) Categories.Fashion; // enum to int conversion
Console.WriteLine(day); //output: 15
		
var wd = (Categories) 5; // int to enum conversion
Console.WriteLine(wd);//output: Food
      }
   }
   }

