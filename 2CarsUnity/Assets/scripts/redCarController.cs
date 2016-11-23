using UnityEngine;
using System.Collections;

public class redCarController : MonoBehaviour {
    public float spawnPosR = -1.87f;
    public float spawnPosL = -0.607f;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag=="food") {
            Destroy(col.gameObject);
        }
        else{
            Destroy(col.gameObject);
        }
    }
}
