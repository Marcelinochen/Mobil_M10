using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Car : MonoBehaviour
{
    public float speed = 3f;
    Vector2 displacement = Vector3.zero;

    void Start()
    {
        
    }

    void Update()
    {
        float xOffset = Input.GetAxisRaw("Horizontal");
        displacement = new Vector2(xOffset * speed * Time.fixedDeltaTime, 0);   
    }

    void FixedUpdate(){
        var rb = GetComponent<Rigidbody2D>();
        float x0 = -2.6f;
        float x1 = 2.6f;
        rb.MovePosition(new Vector2(
            Mathf.Clamp(rb.position.x + displacement.x, x0, x1),
            rb.position.y + displacement.y
        ));
    }
}
