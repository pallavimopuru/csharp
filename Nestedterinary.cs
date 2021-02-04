using System;
namespace freshers
{
  
					
 class Nestedterinary
{
	static void Main(string[] args)
        {
          
		int Phvalue1 = 1, Phvalue2 = 6,Phvalue3 = 5;

		string result = Phvalue2 > Phvalue1 ? "It is Acid": 
						Phvalue2 < Phvalue3 ? "It is Base" :
					    Phvalue3 == Phvalue2 ? "Exhausted" : "No result";
		
		Console.WriteLine(result);
	}
}
}