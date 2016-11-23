using UnityEngine;
//using System.Collections;

public class enemyCarMove : MonoBehaviour
{
    public float speed;

    // Use this for initialization
    void Start()
    {
        speed = 5f;
        //QualitySettings.vSyncCount = 0;

    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(transform.position.x, transform.position.y - (speed * Time.deltaTime), transform.position.z);

    }
}

