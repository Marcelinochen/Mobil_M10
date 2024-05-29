using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run_Car : MonoBehaviour
{
    public float Speed = 3f;

    void FixedUpdate(){
        var rb = GetComponent<Rigidbody2D>();
        rb.MovePosition(rb.position + (Vector2.down * Speed * Time.fixedDeltaTime));
    }

    void OnBecameInvisible(){
        Destroy(gameObject);
    }
}
