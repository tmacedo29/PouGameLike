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
    SetHungryLevel(currentHundgryLevel + 0.01);
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

}