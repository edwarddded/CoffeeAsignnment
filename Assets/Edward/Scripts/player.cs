using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class player : MonoBehaviour
{
    public float movementspeed = 8f;
    Rigidbody2D rb2d;
    float movement = 0f;
    public Animator animator;
    public AudioClip audioClip;
    public AudioSource audioSource;
    private Vector3 scalechange1;
    private Vector3 scalechange;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        scalechange1 = new Vector3(3f,3f,3f);
        
        scalechange = new Vector3(5f, 5f, 5f);
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
        if (other.gameObject.CompareTag("milk"))
        {
            Destroy(other.gameObject);
            audioSource.clip = audioClip;
            audioSource.Play();

        }
        if (other.gameObject.CompareTag("collision"))
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
        if (other.gameObject.CompareTag("End2"))
        {
            SceneManager.LoadScene(4);
        }
        if (other.gameObject.CompareTag("End3"))
        {
            SceneManager.LoadScene(5);
        }
        if (other.gameObject.CompareTag("chicken"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (other.gameObject.CompareTag("water"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (other.gameObject.CompareTag("spwater"))
        {
            Destroy(other.gameObject);
            audioSource.clip = audioClip;
            audioSource.Play();
            movementspeed = 14f;
        }
        if (other.gameObject.CompareTag("spcoffeebean"))
        {
            Destroy(other.gameObject);
            audioSource.clip = audioClip;
            audioSource.Play();
            gameObject.transform.localScale = scalechange;
        }
        if (other.gameObject.CompareTag("sp"))
        {
            Destroy(other.gameObject);
            audioSource.clip = audioClip;
            audioSource.Play();
            gameObject.transform.localScale = scalechange1;
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
