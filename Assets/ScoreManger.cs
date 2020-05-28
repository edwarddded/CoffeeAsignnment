using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManger : MonoBehaviour
{
    public static ScoreManger instance;
    public Text text;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    
    public void ChangeScore(int value)
    {
        score += value;
        text.text = "Current Score:" + score.ToString();
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
