using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Racket : MonoBehaviour {

    public float moveSpeed = 10;
    public Text scoreText;
    protected int Score;

    public void SkorYap()
    {
        Score++;
        scoreText.text = Score.ToString();
    }
}
