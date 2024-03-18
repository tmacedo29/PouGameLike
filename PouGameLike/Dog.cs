namespace PouGameLike;

public class Dog : Character
{
  //---------------------------------------------------------------------------------------------------------------------------

  public Dog() : base()
  {
    SetHungryLevel(0.6);
    SetThurstyLevel(0);
  }

  //---------------------------------------------------------------------------------------------------------------------------

  public override string GetImageName()
  {
    return "dog.png";
  }

  //---------------------------------------------------------------------------------------------------------------------------

  public override void Eat()
  {
    var currentHundgryLevel = GetHungryLevel();
    SetHungryLevel(currentHundgryLevel + 0.05);
  }

  //---------------------------------------------------------------------------------------------------------------------------

  public override void Drink()
  {
    var currentThurstyLevel = GetThurstyLevel();
    SetThurstyLevel(currentThurstyLevel + 0.2);
  }

  //---------------------------------------------------------------------------------------------------------------------------

  public override void Play()
  {
    var currentSadnessLevel = GetSadnessLevel();
    SetSadnessLevel(currentSadnessLevel + 0.1);
  }

  //---------------------------------------------------------------------------------------------------------------------------

  public override void TimePassed()
  {
    var currentSadnessLevel = GetSadnessLevel();
    SetSadnessLevel(currentSadnessLevel - .01);

    var currentThurstyLevel = GetThurstyLevel();
    SetThurstyLevel(currentThurstyLevel - .02);

    var currentHundgryLevel = GetHungryLevel();
    SetHungryLevel(currentHundgryLevel - .05);
  }

  //---------------------------------------------------------------------------------------------------------------------------

}