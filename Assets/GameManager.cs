using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public int currentLives = 3;
	// Use this for initialization
	private int brickCount ;
	private int totalCount;
	public GameObject ball;
	public GameObject paddle;
	public GUIText lives;
	public GUIText scoreText;
	public GUIText Gameover;
	public int score = 0;
	public static GameManager instance ;

	private GameObject clonePaddle;
	private GameObject cloneBall;
	void Start () {
		GameObject brick = GameObject.Find ("blueBlock");

	}

	void Awake(){
		instance = this;
	}


	// Update is called once per frame
	void Update () {

		brickCount =  GameObject.FindGameObjectsWithTag("brick").Length;
		//Debug.Log (currentLives);
	}

	public void LoseLife()
	{
		currentLives--;
		lives.text = currentLives + " ";
		cloneBall = Instantiate (ball, new Vector3(0.05f,-3.5f,0), Quaternion.identity) as GameObject;
		clonePaddle = Instantiate (paddle, new Vector3 (0.05f, -3.7f, 0), Quaternion.identity) as GameObject;

		if (currentLives == 0) {
			Gameover.text = "GAME OVER";
			Application.LoadLevel("GAMEOVER");

		}


	}
}
