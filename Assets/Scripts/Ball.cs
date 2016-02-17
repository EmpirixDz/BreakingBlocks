using UnityEngine;
using System.Collections;


public class Ball : MonoBehaviour {
    
    public float speed = 100.0f; //Movement speed
	void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed; //Ball speed when going up, also it lets the ball move when the game starts.
	}
	
    //Ability to control the ball's direction when it hits the racket.
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "racket")
        {
            float x = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.x); //Calculate hit factor.
            Vector2 dir = new Vector2(x, 1).normalized; //Calculate direction.
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
        if (col.gameObject.name == "border_bottom")
        {
            Destroy(gameObject);

        }

    }

    //y value should be always 1 because the ball is always going up.
    //x value will be between -1 and 1
    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketWidth)
    {
        return (ballPos.x - racketPos.x) / racketWidth;

    }
    public void StopBall()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }
}
