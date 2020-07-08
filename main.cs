using System;

class MainClass{ 
  public static void Main (string[] args) { 
  
   int counter = 1;
   double bmi = 0;

  Console.WriteLine("How many participants checking their BMI?");
  int numberOfParticipants = Convert.ToInt32(Console.ReadLine());

  while(counter <= numberOfParticipants)
  {
    Console.WriteLine("Enter height");
    double height = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter weight");
    double weight = Convert.ToDouble(Console.ReadLine());

    bmi = (weight * 703)/(height * height);

    if (bmi >= 18.5)
    {
      Console.WriteLine("Underweight");
    }


    counter++;
  }
  }
}