using UnityEngine;
using System.Collections;

public class BlockScript : MonoBehaviour {

    public int hitsToKill;
    public int points;
    private int numberOfHits;
	void Start () {
        numberOfHits = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            numberOfHits++;
            if (numberOfHits == hitsToKill)
            {
                GameObject player = GameObject.FindGameObjectsWithTag("player")[0];
                player.SendMessage("addPoints", points);
                Destroy(this.gameObject);

            }
        }
    }
}
