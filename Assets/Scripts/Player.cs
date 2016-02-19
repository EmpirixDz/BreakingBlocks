using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    public float speed = 150;
    private Vector3 playerPosition;
    public float boundary;
    private int playerLives;
    private int playerPoints;
	// Use this for initialization
	void Start () {
        playerPosition = gameObject.transform.position; //get the racket position
        playerLives = 3;
        playerPoints = 0;
	}
	
	// Update is called once per frame
	void Update () {
        playerPosition.x += Input.GetAxis("Horizontal") * speed; //movement

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
    void addPoints(int points)
    {
        playerPoints += points;
    }
    void OnGUI()
    {
        GUI.Label(new Rect(5.0f, 3.0f, 200.0f, 200.0f), "Live's: " + playerLives + " Score: " + playerPoints);

    }

    void TakeLife()
    {
        playerLives--;
    }
}
