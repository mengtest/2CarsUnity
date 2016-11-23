using UnityEngine;
//using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class uiManager : MonoBehaviour {
    public Button[] buttons;
    public Button buttonRed;
    public Button buttonBlue;
    public Text currentScore;
    public Text highScore;
    public int uHighScore;
    public int score;
    public Button pauseButton;
    public Sprite play;
    public Sprite pause;
    // Use this for initialization
    void Start () {
        DisableAutoRotation();
        score = 0;
        uHighScore= PlayerPrefs.GetInt("HighScore");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Pause() {
        if (Time.timeScale == 1) {
            pauseButton.GetComponent<Image>().sprite = play;
            Time.timeScale = 0;
        } else if (Time.timeScale==0) {
            pauseButton.GetComponent<Image>().sprite = pause;
            Time.timeScale = 1;
        }
    }
    public void playGame() {
        SceneManager.LoadScene("level01");
        Time.timeScale = 1;
    }
    public void exitGame() {
        Application.Quit();
    }
    public void goToMenu() {
        SceneManager.LoadScene("menu");
    }
    public void gameOverAcivate() {
        highScore.gameObject.SetActive(true);
        pauseButton.gameObject.SetActive(false);
        buttonBlue.gameObject.SetActive(false);
        buttonRed.gameObject.SetActive(false);
        Pause();
        foreach (Button button in buttons) {
            button.gameObject.SetActive(true);
        }
    }
    public void DisableAutoRotation()
    {
        Screen.autorotateToPortrait = false;
        Screen.autorotateToPortraitUpsideDown = false;
        Screen.orientation = ScreenOrientation.Portrait;
    }
}
