using UnityEngine;
using uGaMa.Mediate;

public class SplashScreenMED : Mediator
{

    SplashScreenView _view;

	// Use this for initialization
	public override void OnRegister()
	{
        Debug.Log("MED OnRegister");
        _view = GetView() as SplashScreenView;

        _view.Message.text = "Hello World!";
	}

	// Update is called once per frame
	public override void OnRemove()
	{
        Debug.Log("MED OnRemove");
    }
}
