using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {
    private bool ballIsActive;
    private Vector3 ballPosition;
    private Vector2 ballInitialForce;
    public GameObject playerObject;
	// Use this for initialization
	void Start () {
        ballInitialForce = new Vector2(100, 5500); //create pushing force
        ballIsActive = false; //set ball to inactive 
        ballPosition = transform.position; //ball position
	}
	
	// Update is called once per frame
	void Update () {
	   if (Input.GetButtonDown ("Jump") == true) {
           if (!ballIsActive)
           {
               GetComponent<Rigidbody2D>().isKinematic = false;
               GetComponent<Rigidbody2D>().AddForce(ballInitialForce);
               ballIsActive = !ballIsActive;
           }
       }
       if (!ballIsActive && playerObject != null)
       {
           ballPosition.x = playerObject.transform.position.x;
           transform.position = ballPosition;
       }
       if (ballIsActive && transform.position.y < -113)
       {
           ballIsActive = !ballIsActive;
           ballPosition.x = playerObject.transform.position.x;
           ballPosition.y = -91.9f;
           transform.position = ballPosition;
           GetComponent<Rigidbody2D>().isKinematic = true;
       }
       
       
	}
}
