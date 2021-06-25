using System;

class MainClass {
  public static void Main (string[] args) {
    //Fruit

    //yellow - lemon, honeydew
    //red - apple, pear
    //green - watermelon, lime

  Console.WriteLine("Enter a fruit name");
  string fruit = Console.ReadLine();

    switch(fruit)
    { 
    case "lemon":
      Console.WriteLine("It is yellow");
      break;
    case "honeydew":
      Console.WriteLine("It is yellow");
      break;
    case "apple":
      Console.WriteLine("It is red");
      break;
    case "pear":
      Console.WriteLine("It is red");
      break;
    case "watermelon":
      Console.WriteLine("It is green");
      break;
    case "lime":
      Console.WriteLine("It is green");
      break;
    default:
      Console.WriteLine("I have no clue what color the fruit is!");
      break;
     }