namespace PouGameLike;


public class Character
{
  //---------------------------------------------------------------------------------------------------------------------------

  double hungryLevel;
  double thurstyLevel;
  double sadnessLevel;

  //---------------------------------------------------------------------------------------------------------------------------

  public Character()
  {
    hungryLevel  = 0;
    thurstyLevel = 0;
    sadnessLevel = 0;
  }

  //---------------------------------------------------------------------------------------------------------------------------

  public virtual string GetImageName()
  {
    return "";
  }

  //---------------------------------------------------------------------------------------------------------------------------
  // Min: 0.0 - Max: 1.0
  protected void SetHungryLevel(double level)
  {
    if (level >= 0 && level <= 1)
      hungryLevel = level;
    else if (level < 0)
      hungryLevel = 0;
    else
      hungryLevel = 1;
  }

  //---------------------------------------------------------------------------------------------------------------------------
  // Min: 0.0 - Max: 1.0
  public double GetHungryLevel()
  {
    return hungryLevel;
  }

  //---------------------------------------------------------------------------------------------------------------------------
  // Min: 0.0 - Max: 1.0
  protected void SetThurstyLevel(double level)
  {
    if (level >= 0 && level <= 1)
      thurstyLevel = level;
    else if (level < 0)
      thurstyLevel = 0;
    else
      thurstyLevel = 1;
  }

  //---------------------------------------------------------------------------------------------------------------------------
  // Min: 0.0 - Max: 1.0
  public double GetThurstyLevel()
  {
    return thurstyLevel;
  }

  //---------------------------------------------------------------------------------------------------------------------------
  // Min: 0.0 - Max: 1.0
  protected void SetSadnessLevel(double level)
  {
    if (level >= 0 && level <= 1)
      sadnessLevel = level;
    else if (level < 0)
      sadnessLevel = 0;
    else
      sadnessLevel = 1;
  }

  //---------------------------------------------------------------------------------------------------------------------------

  public double GetSadnessLevel()
  {
    return sadnessLevel;
  }

  //---------------------------------------------------------------------------------------------------------------------------

  public virtual void Eat()
  {
    var currentHundgryLevel = GetHungryLevel();
    SetHungryLevel(currentHundgryLevel + 0.1);
  }

  //---------------------------------------------------------------------------------------------------------------------------

  public virtual void Drink()
  {
    var currentThurstyLevel = GetThurstyLevel();
    SetThurstyLevel(currentThurstyLevel + 0.1);
  }

  //---------------------------------------------------------------------------------------------------------------------------

  public virtual void Play()
  {
    var currentSadnessLevel = GetSadnessLevel();
    SetSadnessLevel(currentSadnessLevel + 0.1);
  }

  //---------------------------------------------------------------------------------------------------------------------------
}