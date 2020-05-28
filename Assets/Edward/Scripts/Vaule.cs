using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vaule : MonoBehaviour
{
    public int vaule = 10;
    private void OnTriggerEnter2D(Collider2D other)
    {
        ScoreManger.instance.ChangeScore(vaule);
    }
}
