using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private TextMeshProUGUI _highScoreText;

    private int _score;
    private int _highScore;


    private void Start()
    {
        Debug.Log(_score);
        _score = 0;
        _highScore = PlayerPrefs.GetInt("HighScore");
        _highScoreText.text = _highScore.ToString();
        _scoreText.text = _score.ToString();
    }

    private void Update()
    {
        if (_score >= _highScore)
        {
            _highScore = _score;
            PlayerPrefs.SetInt("HighScore", _highScore);
            _highScoreText.text = _highScore.ToString();
        }
    }

    public void UpdateValue()
    { 
        Debug.Log("Click");
        _score++;

        _scoreText.text = _score.ToString();
        PlayerPrefs.SetInt("Score", _score);
        PlayerPrefs.Save();
        Debug.Log("Score" +  _score);
    }
}
