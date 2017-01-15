using uGaMa.Command;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneCMD : Command
{
	public override void Execute(NotifyParam notify)
	{
        string param = notify.data as string;
        Debug.Log("LoadSceneCMD Execute : "+param);
        SceneManager.LoadScene(param);
    }
}
