using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveupward : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 4f;
    public float PositionMin;
    public float PositionMax;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.position += Vector3.up * speed * Time.deltaTime;
        if (transform.position.y >= PositionMax || transform.position.y <= PositionMin)
        {
            speed = -speed;
        }
    }
}
