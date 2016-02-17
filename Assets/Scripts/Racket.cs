using UnityEngine;
using System.Collections;

public class Racket : MonoBehaviour {

    public float speed = 150; //The racket movement speed
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal"); //Detects Horizontal input (A/D, Left/Righ arrows, or a gamepad) 
        GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed; //this allows for the racket move left or right
    }

}
