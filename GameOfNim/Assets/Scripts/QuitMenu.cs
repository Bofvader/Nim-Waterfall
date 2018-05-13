using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitMenu : MonoBehaviour
{
	/// <summary>
	/// Load up the main menu scene (MainMenu)
	/// </summary>
	public void ReturnToMain()
	{
		SceneManager.LoadScene("MainMenu");
	}

	/// <summary>
	/// Quit application
	/// </summary>
	public void FullQuit()
	{
		Application.Quit();
	}
}
