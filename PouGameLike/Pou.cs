namespace PouGameLike;

public class Pou : Character
{
  //---------------------------------------------------------------------------------------------------------------------------

  public Pou() : base()
  {
    SetHungryLevel(0.4);
    SetThurstyLevel(0.6);
    SetSadnessLevel(0.5);
  }

  //---------------------------------------------------------------------------------------------------------------------------

  public override string GetImageName()
  {
    return "pou.png";
  }

  //---------------------------------------------------------------------------------------------------------------------------

  public override void Eat()
  {
    var currentHundgryLevel = GetHungryLevel();
    SetHungryLevel(currentHundgryLevel + 0.1);
  }

  //---------------------------------------------------------------------------------------------------------------------------

  public override void Drink()
  {
    var currentThurstyLevel = GetThurstyLevel();
    SetThurstyLevel(currentThurstyLevel + 0.1);
  }

  //---------------------------------------------------------------------------------------------------------------------------

  public override void Play()
  {
    var currentSadnessLevel = GetSadnessLevel();
    SetSadnessLevel(currentSadnessLevel + 0.1);
  }

  //---------------------------------------------------------------------------------------------------------------------------

}