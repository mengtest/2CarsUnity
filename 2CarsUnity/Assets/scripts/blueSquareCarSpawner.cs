using UnityEngine;
//using System.Collections;

public class blueSquareCarSpawner : MonoBehaviour {

    public GameObject[] blueSquareCar;
    int carNo;
    public float spawnPosR = 1.867f;
    public float spawnPosL = 0.607f;
    public int rand;
    public float delayTime = 0.5f;
    public float timer;
    // Use this for initialization
    void Start() {
        timer = delayTime;
        
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer<=0) {
            rand = Random.Range(0, 3);
            if (rand == 1)
            {
                int randCar = Random.Range(0, 2);
                carNo = randCar;
                Vector3 carPos = new Vector3(spawnPosL, transform.position.y, transform.position.z);
                Instantiate(blueSquareCar[carNo], carPos, transform.rotation);
            }
            else
            {
                int randCar = Random.Range(0, 2);
                carNo = randCar;
                Vector3 carPos = new Vector3(spawnPosR, transform.position.y, transform.position.z);
                Instantiate(blueSquareCar[carNo], carPos, transform.rotation);
            }
            timer = delayTime;
        }
        
    }
}
