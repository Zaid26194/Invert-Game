using UnityEngine;
using System.Collections;

public class MeteorMover : MonoBehaviour {
    //private float speed = -2f;
    private GameControl gameController;
    private Rigidbody2D rigidBody;

	// Use this for initialization
	void Start () {
        gameController = GameObject.FindObjectOfType<GameControl>();
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(0, gameController.speed); //Give meteor initial downward speed
	}
}
