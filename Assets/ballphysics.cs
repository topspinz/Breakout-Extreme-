using UnityEngine;
using System.Collections;

public class ballphysics : MonoBehaviour {

	// Use this for initialization
	public float initialSpeed;
	public float maxSpeed;
	private bool ballInPlay;
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		rigidbody2D.velocity = initialSpeed * (rigidbody2D.velocity.normalized);
		GameObject go = GameObject.FindGameObjectWithTag ("paddle");
		if (Input.GetKey (KeyCode.Space) && ballInPlay == false) {
				
						go.GetComponent<movement> ().startBall = true;
						transform.parent = null;
						ballInPlay = true;
						ForcePush ();
						
				}
	

	//	Debug.Log (rigidbody2D.velocity);
	}
	

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "paddle") 	BallHitPaddle ();
		}

	void ForcePush() {

		rigidbody2D.AddForce (-Vector2.up* initialSpeed, ForceMode2D.Impulse);
		Vector2 dir = new Vector2 (1, 1).normalized;
		rigidbody2D.velocity = dir * initialSpeed;

	}

	void BallHitPaddle()
	{
		GameObject paddle = GameObject.FindGameObjectWithTag("paddle");
		Vector2 paddlePosition = paddle.transform.position;
		Vector2 ballPosition = gameObject.transform.position;	
		// this is the vector 'pointing' from the paddle to the ball
		Vector2 delta = ballPosition - paddlePosition;	
		// normalizing converts a vector into a unit vector
		// (i.e. a vector with the same direction, but a magnitude of 1)
		Vector2 direction = delta.normalized;
		// set the velocity to be the direction vector scaled to the desired speed
		rigidbody2D.velocity = direction ;
	}

}	