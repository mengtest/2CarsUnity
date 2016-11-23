using UnityEngine;
using UnityEngine.UI;
//using System.Collections;

public class carController : MonoBehaviour {
    public float rSpawnPosR = -1.87f;
    public float rSpawnPosL = -0.607f;
    public float bSpawnPosR = 1.867f;
    public float bSpawnPosL = 0.607f;
    public int redFlag = 0;
    public int blueFlag = 0;
    public uiManager ui;
    
   // bool currentPlatformAndroid = false;



    // Use this for initialization
  /*  void Awake() {
        #if UNITY_ANDROID
                currentPlatformAndroid = true;
        #else
                currentPlatformAndroid=false;
        #endif
    }*/


    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

	}
    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag=="food") {
            ui.score += 1;
            ui.currentScore.text = ui.score.ToString();
            Destroy(col.gameObject);
        }

        else{
            if (ui.score > ui.uHighScore) {
                PlayerPrefs.SetInt("HighScore",ui.score);
            }
            ui.highScore.text = "High Score: "+ PlayerPrefs.GetInt("HighScore").ToString();
            Destroy(gameObject);
            ui.gameOverAcivate();
        }
    }


    public void rMove(){
        if (redFlag == 0) {
            transform.position = Vector3.MoveTowards(transform.position,new Vector3(rSpawnPosL, transform.position.y, transform.position.z), 5f);
            redFlag = 1;
        } else if (redFlag==1) {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(rSpawnPosR, transform.position.y, transform.position.z), 5f);
            redFlag = 0;
        }
        
    }
    public void bMove()
    {
        if (redFlag == 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(bSpawnPosL, transform.position.y, transform.position.z), 5f);
            redFlag = 1;
        }
        else if (redFlag == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(bSpawnPosR, transform.position.y, transform.position.z), 5f);
            redFlag = 0;
        }

    }

}


