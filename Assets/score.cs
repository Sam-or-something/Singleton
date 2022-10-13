using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txtScore;
    public int scorePoints;

    void Start()
    {
        scorePoints = 0;
        ScoreUpdate();
    }

    public void AddPoints(int points)
    {
        scorePoints += points;
        ScoreUpdate();
    }

    public void ScoreUpdate()
    {
        txtScore.text = "Score: " + scorePoints.ToString();
    }
}
