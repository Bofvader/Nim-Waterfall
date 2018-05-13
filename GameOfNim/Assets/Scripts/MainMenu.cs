using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public void GoToQuit()
	{
		SceneManager.LoadScene("QuitMenu");
	}

	public void GoToRules()
	{
		SceneManager.LoadScene("RulesMenu");
	}

	public void GoToSetup()
	{
		SceneManager.LoadScene("SetupMenu");
	}
}
