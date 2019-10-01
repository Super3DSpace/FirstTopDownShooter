using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;

    private float y_speed;
    private float x_speed;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        y_speed = Input.GetAxis("Vertical");
        x_speed = Input.GetAxis("Horizontal");


        Vector2 direction = new Vector2(x_speed, y_speed);
        GetComponent<Rigidbody2D>().velocity = direction.normalized * speed ;

    }
}
