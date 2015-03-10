using UnityEngine;
using System.Collections;

public class block : MonoBehaviour {




	//public Transform transBlock;
	void Start () {

		}
	
	// Update is called once per frame
	void Update () {
	}
	//If the ball collides with the block is destroyed and get 10
	void OnCollisionEnter2D (Collision2D other)
	{

		if (other.gameObject.name == "blueBlock") {
			GameManager.instance.score += 10;
			Destroy (other.gameObject);
			GameManager.instance.scoreText.text = "" + GameManager.instance.score;
		}
	}


	
}