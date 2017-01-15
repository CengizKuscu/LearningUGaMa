using uGaMa.Context;

public class MainMenuContext : Context
{

	public override void Bindings()
	{
        mediatorMap.Bind<MainMenuView>().To<MainMenuMED>();

        commandMap.Bind(AppEvent.LOAD_SCENE).To<LoadSceneCMD>();
        commandMap.Bind(AppEvent.QUIT).To<QuitGameCMD>();
	}

	public override void UnBindings()
	{

	}
}
