using UnityEngine;
using uGaMa.Mediate;
using System;
using UnityEngine.SceneManagement;

public class MainMenuMED : Mediator
{
    MainMenuView _view;

	// Use this for initialization
	public override void OnRegister()
	{
        _view = GetView() as MainMenuView;

        _view.PlayBtn.onClick.AddListener(PlayGameBtn);
        _view.QuitBtn.onClick.AddListener(QuitGameBtn);
	}

    private void QuitGameBtn()
    {
        Debug.Log("QuitGame");
        dispatcher.Dispatch(AppEvent.QUIT);
    }

    private void PlayGameBtn()
    {
        Debug.Log("PlayGame");
        dispatcher.Dispatch(AppEvent.LOAD_SCENE, AppScenes.LEVEL_1);
    }

    // Update is called once per frame
    public override void OnRemove()
	{

	}
}
