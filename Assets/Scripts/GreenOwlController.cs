using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenOwlController : MonoBehaviour
{
    public float flapForce = 300f;  // The upward force applied when flapping
    private Rigidbody2D rb2d;

    void Start()
    {
        // Get the Rigidbody2D component attached to the GameObject
        rb2d = GetComponent<Rigidbody2D>();
    }

    public void FlapUp()
    {
        // Zero out the velocity before applying the force
        rb2d.velocity = Vector2.zero;

        // Apply upward force to the Rigidbody2D
        rb2d.AddForce(new Vector2(0, flapForce));
    }
}
