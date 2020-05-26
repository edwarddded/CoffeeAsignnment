using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayLevel()
    {
        SceneManager.LoadScene(2);
    }
    public void BackLevel()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitLevel()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
