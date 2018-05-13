using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	/// <summary>
	/// Load up the quiting scene (QuitMenu)
	/// </summary>
	public void GoToQuit()
	{
		SceneManager.LoadScene("QuitMenu");
	}

	/// <summary>
	/// Load up the rules scene (RulesMenu)
	/// </summary>
	public void GoToRules()
	{
		SceneManager.LoadScene("RulesMenu");
	}

	/// <summary>
	/// Load up the setup scene (SetupMenu)
	/// </summary>
	public void GoToSetup()
	{
		SceneManager.LoadScene("SetupMenu");
	}
}
