using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float jumpforce = 2f;
    void OnCollisionEnter2D(Collision2D collision)
    {   if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb2d = collision.collider.GetComponent<Rigidbody2D>();
            if (rb2d != null)
            {
                Vector2 velocity = rb2d.velocity;
                velocity.y = jumpforce;
                rb2d.velocity = velocity;
            }
        }
    }
}
