using System;

class MainClass {

  public static void CalculateCharges(double hours){
    double additional;
    if (hours <= 3){
      Console.WriteLine("The total parking charges are 2.00$");
    }
    else if (( hours > 3) && (hours < 24)){
      additional = (0.50 * (hours - 3.00)) + 2.00;
      Console.WriteLine("The total parking charges are " + additional + "$");
    }
    else if( hours == 24){
      Console.WriteLine("The total parking charges are 10.00$");
    }
    
  }

  public static void Main (string[] args) {
    Console.WriteLine ("parking charges ");

    int count = 0;
    
    do {
      Console.WriteLine("Enter the hours for the customer");
      double hours= Convert.ToDouble(Console.ReadLine());
      CalculateCharges(hours);
      Console.WriteLine("Is there any other customer?");
      string newcus = Console.ReadLine();
      string lower = newcus.ToLower();

      if (newcus[0] == 'n'){
      count = 1;
      }
    }while (count == 0);
    Console.WriteLine("We're done");
  }
}