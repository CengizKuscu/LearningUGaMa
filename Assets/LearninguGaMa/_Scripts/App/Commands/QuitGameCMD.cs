using uGaMa.Command;
using UnityEngine;

public class QuitGameCMD : Command
{

	public override void Execute(NotifyParam notify)
	{
        Debug.Log("QUIT CMD Execute");
        Application.Quit();
	}
}
