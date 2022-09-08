namespace LeapYear;
public class LeapYearcalc
{


public static void Main(string[] args) {


try{
  var lyc = new LeapYearcalc();

  Console.WriteLine("Enter a year here, and press [Enter]");

      // Create a string variable and get user input from the keyboard and store it in the variable
      int Useryear = Convert.ToInt32(Console.ReadLine());

       if(Useryear<1582) {
        Console.WriteLine("invalid input-choose a year from 1582");


       }

      else if(lyc.isLeapYear(Useryear)==true){

        Console.WriteLine("yay"); }

        else {

          Console.WriteLine("nay");

         


          }
      } 
      catch(Exception e){

        Console.WriteLine(e.Message);
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
 





 






