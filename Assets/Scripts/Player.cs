using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    public float playerVelocity;
    private Vector3 playerPosition;
    public float boundary;
	// Use this for initialization
	void Start () {
        playerPosition = gameObject.transform.position; //get the racket position
	}
	
	// Update is called once per frame
	void Update () {
        playerPosition.x += Input.GetAxis("Horizontal") * playerVelocity; //movement

        //Quit the game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        transform.position = playerPosition; //updates the racket position

        if (playerPosition.x < -boundary)
        {
            playerPosition.x = -boundary;
        }
        if (playerPosition.x > boundary)
        {
            playerPosition.x = boundary;
        }
        transform.position = playerPosition;
	}
}
