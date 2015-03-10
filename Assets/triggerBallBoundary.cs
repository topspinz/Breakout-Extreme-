using UnityEngine;
using System.Collections;

public class triggerBallBoundary : MonoBehaviour {

	//public GameManager GM ;

	void Start()
	{


	}
	void Update () {

		

		//GameManager.instance.LoseLife();
		}


	void OnTriggerEnter2D(Collider2D other) {
		GameObject paddle = GameObject.FindWithTag ("paddle");
		if (other.gameObject.tag == "ball") {

			Destroy (other.gameObject);
			Destroy(paddle);
			GameManager.instance.LoseLife();

		}
	


}


}
