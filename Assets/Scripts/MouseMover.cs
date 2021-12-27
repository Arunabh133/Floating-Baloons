using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMover : MonoBehaviour
{
   public float pushPower = 50.0f;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 dir = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            dir = dir.normalized;

            rb.AddForce(dir * pushPower, ForceMode2D.Force);

            // as alternative:
            rb.velocity = dir * pushPower;
        }
    }
}

