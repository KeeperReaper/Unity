using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {
    

    void Start () {
    }

    public void gotoGameScene(String scene)
    {
        SceneManager.LoadScene(scene);
    }
    void Update () {
    }
}
