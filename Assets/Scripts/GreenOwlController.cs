using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenOwlController : MonoBehaviour
{
    public float flapForce = 300f;  // The upward force applied when flapping
    public float rotationSpeed = 10f;
    private Rigidbody2D rb2d;

    void Start()
    {
        // Get the Rigidbody2D component attached to the GameObject
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, rb2d.velocity.y * rotationSpeed);
    }

    public void FlapUp()
    {
        // Zero out the velocity before applying the force
        rb2d.velocity = Vector2.zero;

        // Apply upward force to the Rigidbody2D
        rb2d.AddForce(new Vector2(0, flapForce));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.instance.GameOver();
    }
}
