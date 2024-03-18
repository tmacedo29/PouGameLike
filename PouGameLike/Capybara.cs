namespace PouGameLike;

public class Capybara : Character
{
  //---------------------------------------------------------------------------------------------------------------------------

  public Capybara() : base()
  {
    SetHungryLevel(0.9);
    SetThurstyLevel(0.6);
  }

  //---------------------------------------------------------------------------------------------------------------------------

  public override string GetImageName()
  {
    return "capybara.png";
  }

  //---------------------------------------------------------------------------------------------------------------------------

  public override void Eat()
  {
    var currentHundgryLevel = GetHungryLevel();
    SetHungryLevel(currentHundgryLevel + .3);
  }

  //---------------------------------------------------------------------------------------------------------------------------

  public override void Drink()
  {
    var currentThurstyLevel = GetThurstyLevel();
    SetThurstyLevel(currentThurstyLevel + .4);
  }

  //---------------------------------------------------------------------------------------------------------------------------

  public override void Play()
  {
    var currentSadnessLevel = GetSadnessLevel();
    SetSadnessLevel(currentSadnessLevel + .4);
  }

  //---------------------------------------------------------------------------------------------------------------------------

}