﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{

    public void LoadScene(string sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}