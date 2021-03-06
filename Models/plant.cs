using System;
namespace Models
{
  public class Plant
  {
    public string Name { get; set; }
    public int Thirst { get; set;}
    public int Hunger { get; set; }
    public int Sunshine { get; set; }
    public int Days { get; set; }
    public string Alive { get; set; }

    public Plant(string name, int thirst, int hunger, int sunshine, int days, string alive)
    {
      Name = name;
      Thirst = thirst;
      Hunger = hunger;
      Sunshine = sunshine;
      Days = days;
      Alive = alive;
    }
    public static void DailyChoice(Plant testPlant)
    {
    Console.WriteLine("What would you like to do today?");
    string userDailyChoice = Console.ReadLine().ToLower();
    if (testPlant.Days % 7 == 0) 
    {
      if (testPlant.Thirst < 12 || testPlant.Hunger < 12 || testPlant.Sunshine < 12)
      {
        testPlant.Death();
      }
    }
      else
      {
        if (userDailyChoice.Contains("water"))
        {
          testPlant.GiveWater();
          testPlant.DisplayStats();
          DailyChoice(testPlant);
        }
        else if (userDailyChoice.Contains("walk"))
        {
          testPlant.GiveSun();
          testPlant.DisplayStats();
          DailyChoice(testPlant);
        }
        else if (userDailyChoice.Contains("feed"))
        {
          testPlant.GiveFood();
          testPlant.DisplayStats();
          DailyChoice(testPlant);
        }
        else if (userDailyChoice.Contains("tv"))
        {
          testPlant.DoNothing();
          testPlant.DisplayStats();
          DailyChoice(testPlant);
        }
      }
    }
    private void GiveWater()
    {
      Thirst += 4;
      Days ++;
    }

    private void GiveFood()
    {
      Hunger += 4;
      Days ++;
    }

    private void GiveSun()
    {
      Sunshine += 4;
      Days ++;
    }

    private void DoNothing()
    {
      Thirst -= 1;
      Sunshine -= 1;
      Hunger -= 1;
      Days ++;
    }
    private void DisplayStats()
    {
      Console.WriteLine("NEW Thirst: " + Thirst);
      Console.WriteLine("NEW Hunger: " + Hunger);
      Console.WriteLine("NEW Sunshine: " + Sunshine);
      Console.WriteLine("Day Count: " + Days);
    }

    private void Death()
    {
      Console.WriteLine(Name + " is dead cause you're worthless and lazy.");
    }
    // private void WeeklyCheckUp()
    // {
    //   if (Days % 7 == 0) 
    // {
    //     if (Thirst < 12 || Hunger < 12 || Sunshine < 12)
    //     {
    //       Death();
          
    //     }
    //   }
    // }
  }
}