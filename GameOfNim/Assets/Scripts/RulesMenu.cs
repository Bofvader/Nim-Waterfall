﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RulesMenu : MonoBehaviour
{
	public void ReturnToMain()
	{
		SceneManager.LoadScene("MainMenu");
	}
}
