using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score instance;
    public Text currentScoreText;
    public Text bestScoreText;

    private int score;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        currentScoreText.text = score.ToString();
        bestScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateHighScore()
    {
        if(score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
            bestScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        }
    }

    public void UpdateScore()
    {
        score++;
        currentScoreText.text = score.ToString();
        UpdateHighScore();
    }
}
