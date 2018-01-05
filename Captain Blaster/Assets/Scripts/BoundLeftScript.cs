using UnityEngine;
using System.Collections;

public class BoundLeftScript : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collider)
    {
        Vector3 boundL = transform.position;
        boundL += new Vector3(3f, -4, 0);
        collider.transform.position = boundL;
    }
}
