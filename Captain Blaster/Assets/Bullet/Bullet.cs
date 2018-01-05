using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
    public float speed = 10f;
    private GameControl gameController;

	// Use this for initialization
	void Start () {
        gameController = GameObject.FindObjectOfType<GameControl>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0f, speed * Time.deltaTime, 0f);
	}

    void OnCollisionEnter2D (Collision2D other){
        Destroy(other.gameObject);
        gameController.AddScore();
        Destroy(gameObject);
    }
}
