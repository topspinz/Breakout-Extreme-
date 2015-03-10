using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour
{

		// Use this for initialization
		Vector2 dir = new Vector2 ();
		public int speed;
		public bool startBall = false;
		private Vector2 playerPosition;
		//public GameObject ball;
		public float minX,maxX;
		void Start ()
		{

		}

		// Update is called once per frame
		void Update ()
		{
		move (); // moves the player from left to right
		GameObject ball = GameObject.Find ("ballPrefab(Clone)"); // tags ball as the ball prefab
		if (startBall == false) {
			ball.transform.parent = this.transform;
			}
		playerPosition = this.gameObject.transform.position; //  sets playerPosition to the the paddles position
		// sets bounds for the x axis
		if (playerPosition.x <= minX)
						transform.position = new Vector2 (minX, playerPosition.y);
		if (playerPosition.x >= maxX)
						transform.position = new Vector2 (maxX, playerPosition.y);

		//Debug.Log (playerPosition);
		}

		void move ()
		{
		
				if (Input.GetKey (KeyCode.RightArrow)) 
						transform.Translate (Vector2.right * Time.deltaTime * speed);	
				if (Input.GetKey (KeyCode.LeftArrow)) 
						transform.Translate (-Vector2.right * Time.deltaTime * speed);		
		}
		
		
	
}