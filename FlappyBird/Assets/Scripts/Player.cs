using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private const float speed = 8f;
    Rigidbody2D rbBirds;


    private void Awake()
    {
        rbBirds = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rbBirds.velocity = Vector2.up * speed;
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            rbBirds.velocity = Vector2.up * speed;
        }

        if (transform.position.y <= -4.05f)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Block")
        {
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Zemin")
        {
            collision.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
        }

    }
}
