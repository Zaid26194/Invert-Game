using UnityEngine;
using System.Collections;

public class DestroyOnTrigger : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collider){
        Destroy(collider.gameObject);
    }
}
