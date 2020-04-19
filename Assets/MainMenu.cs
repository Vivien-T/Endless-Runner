﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void BoutonStart()
    {
        SceneManager.LoadScene("Game");
    }

    public void BoutonQuit()
    {
        Application.Quit();
    }
}
