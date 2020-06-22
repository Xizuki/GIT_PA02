using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score : " + PlayerPrefs.GetInt("score");
        highScoreText.text = "High Score : " + PlayerPrefs.GetInt("high score");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
