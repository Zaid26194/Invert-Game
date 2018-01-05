using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class ShipControlScript : MonoBehaviour {
    public float playerSpeed = 10f;
    public AudioSource shotSound;
    public GameControl gameController;
    public GameObject bulletPrefab;
    public float reloadTime = 0.5f; //Bullets can fire every 0.5 seconds
    private bool invert = false;
    private float elapsedTime = 0;

    // Update is called once per frame
    void Update() {
        elapsedTime += Time.deltaTime;

        //Move player from left to right
        float xMovement = CrossPlatformInputManager.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
        float xPosition = Mathf.Clamp(xMovement, -7f, 7f); //Keeps ship on screen

        if (invert){
            transform.Translate(xPosition * -1, 0f, 0f);
        }
        else{
            transform.Translate(xPosition, 0f, 0f);
        }

        if (CrossPlatformInputManager.GetButtonDown("Shoot") && elapsedTime > reloadTime) {
            Vector3 spawnPos = transform.position;
            spawnPos += new Vector3(0, 1f, 0);
            shotSound.pitch = Random.Range(0.5f, 0.8f);
            shotSound.volume = Random.Range(0.05f, 0.15f);
            shotSound.Play();
            Instantiate(bulletPrefab, spawnPos, Quaternion.identity);

            invert = !invert;

            elapsedTime = 0f;
        }

        if (reloadTime > 0.2f){
            reloadTime -= Time.deltaTime / 300;
        }
    }

    void OnTriggerEnter2D (Collider2D other){
        if (other.tag == "Meteor")
        {
            gameController.PlayerDied();
        }
    }
}
