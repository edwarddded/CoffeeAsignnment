using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{
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

        transform.position += Vector3.right * speed * Time.deltaTime;
        if (transform.position.x >= PositionMax || transform.position.x <= PositionMin)
        {
            speed = -speed;
        }
    }
}
