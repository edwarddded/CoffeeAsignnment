﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void BackLevel()
    {
        SceneManager.LoadScene(1);
    }
}
