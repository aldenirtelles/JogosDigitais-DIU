using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int totalScore;
    public Text scoreText;

    public static GameController instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    void Update()
    {
        
    }

    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString();
    }

    public void NewGame(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
    }
}
