using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class player : MonoBehaviour
{
    float movementspeed = 8f;
    Rigidbody2D rb2d;
    float movement = 0f;
    public Animator animator;
    public AudioClip audioClip;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        //ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other .gameObject.CompareTag("sugar"))
        {
            Destroy(other.gameObject);
            audioSource.clip = audioClip;
            audioSource.Play();

        }
        if (other.gameObject.CompareTag("saw"))
        {
            SceneManager.LoadScene(2);
        }
        if (other.gameObject.CompareTag("End"))
        {
            SceneManager.LoadScene(3);
        }
        if (other.gameObject.CompareTag("chicken"))
        {
            SceneManager.LoadScene(2);
        }
    }
    void Update()
    {
         movement = Input.GetAxis("Horizontal")* movementspeed;
         animator.SetFloat("Speed", Mathf.Abs(movement));
    }
    void FixedUpdate()
    {
        Vector2 velocity = rb2d.velocity;
        velocity.x = movement;
        rb2d.velocity = velocity;
    }
}
