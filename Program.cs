using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "0123456789";
      string specialChars = "#?!,-'/`_*$";
      
      //user to enter a password 
      Console.WriteLine("Please enter your password: ");
      
      //captures their input in a variable
      string password =Console.ReadLine();
      
      //scores the user password
      int score = 0;
      
      //If the password is >= to the minimum length, it adds a point to the score
      if ((score) >= (minLength))
      {
        score++;
      }      
      
			//If the password contains uppercase letters, add a point
      if (Tools.Contains(password, uppercase))
      {
        score++;
      }
      
			//If the password contains lowercase letters, add a point
      if (Tools.Contains(password, lowercase))
      {
        score++;
      }
           
			//If the password contains digits, add a point
      if (Tools.Contains(password, digits))
      {
        score++;
      }
      
			//If the password contains special characters, add a point
      if (Tools.Contains(password, specialChars))
      {
        score++;
      }
           
      Console.WriteLine(password);
      Console.WriteLine(score);
      
      //based on the score, let the user know how they did
      switch (score) 
      {
        case 5:
        case 4:
          Console.WriteLine("This is an extremely strong password!");
          break;
        case 3:
          Console.WriteLine("This is a strong password!");
          break;
        case 2:
          Console.WriteLine("This is an average password");
          break;
        case 1:
          Console.WriteLine("This is a weak password!");
          break;
        default:
          Console.WriteLine("This password doesn't meet the standards!");
          break;
      } 
      Console.ReadLine();
    }
  }
}
