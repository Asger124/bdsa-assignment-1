namespace LeapYear;
public class LeapYearcalc
{


public static void Main(string[] args) {

  var lyc = new LeapYearcalc();

  Console.WriteLine("Enter a year here, and press [Enter]");

      // Create a string variable and get user input from the keyboard and store it in the variable
      int Useryear = Convert.ToInt32(Console.ReadLine());

      if(lyc.isLeapYear(Useryear)==true){

        Console.WriteLine("yay"); }

        else {

          Console.WriteLine("nay");
          }
      }



 public bool isLeapYear(int year){

if(year % 400==0) 
   { 
    return true; 
    }

  else if(year%100==0 ) 
  {

    return false;
    } 
    else if (year % 4 ==0 ){
    return true;
    } else {return false; 
    }
 }
}
 





 






