using uGaMa.Context;
using UnityEngine;

public class SplashScreenContext : Context
{

	public override void Bindings()
	{
        Debug.Log("CONTEXT Bindings");
        mediatorMap.Bind<SplashScreenView>().To<SplashScreenMED>();
	}

	public override void UnBindings()
	{
        Debug.Log("CONTEXT UnBindings");
    }
}
