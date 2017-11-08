using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {
    int min = 1, max = 1001, guess, life = 4;
    public Text Guess;
    // Use this for initialization
    void Start () {
        ChangeGuess();
    }

    public void gotoGameScene(String scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void changeMinMax(Boolean Higher) {
        if (Higher) min = guess;
        else max = guess;
        ChangeGuess();
    }

    void ChangeGuess() {
        life--;
        guess = UnityEngine.Random.Range(min, max);
        if (life != 0) Guess.text = "Current guess:\n " + guess;
    }
    // Update is called once per frame
    void Update () {
        if (life == 0) SceneManager.LoadScene("Win");
    }
}
