namespace PouGameLike;

public partial class MainPage : ContentPage
{
  //--------------------------------------------------------------------------------------------------

  List<Character> CharacterList = new List<Character>();
  Character CurrentCharacter;
  int currentCharacterIndex = 0;

  //--------------------------------------------------------------------------------------------------

	public MainPage()
	{
		InitializeComponent();

    CharacterList.Add(new Capybara());
    CharacterList.Add(new Dog());
    CharacterList.Add(new Pou());

    Init();
	}

  //--------------------------------------------------------------------------------------------------

  void Init()
  {
    CurrentCharacter = CharacterList[currentCharacterIndex];
    PageConfigure();
  }

  //--------------------------------------------------------------------------------------------------

  void PageConfigure()  
  {
    imgCharacter.Source = CurrentCharacter.GetImageName();
    progressBarSadness.Progress = CurrentCharacter.GetSadnessLevel();
    progressBarHungry.Progress  = CurrentCharacter.GetHungryLevel();
    progressBarThursty.Progress = CurrentCharacter.GetThurstyLevel();
  }

  //--------------------------------------------------------------------------------------------------

  void OnChangeCharacterClicked(object sender, EventArgs args)
  {
    currentCharacterIndex += 1;
    if(currentCharacterIndex == CharacterList.Count)
      currentCharacterIndex = 0;

    CurrentCharacter = CharacterList[currentCharacterIndex];
    PageConfigure();
  }

  //--------------------------------------------------------------------------------------------------

  void OnPlayClicked(object sender, EventArgs args)
  {
    CurrentCharacter.Play();
    PageConfigure();
  }

  //--------------------------------------------------------------------------------------------------

    
  void OnFoodClicked(object sender, EventArgs args)
  {
    CurrentCharacter.Eat();
    PageConfigure();
  }

  //--------------------------------------------------------------------------------------------------

    
  void OnDrinkClicked(object sender, EventArgs args)
  {
    CurrentCharacter.Drink();
    PageConfigure();
  }

  //--------------------------------------------------------------------------------------------------
}

