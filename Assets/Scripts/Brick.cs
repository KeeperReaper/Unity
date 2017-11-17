using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
    LevelManager levelM = new LevelManager();
    public int maxHit;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        maxHit--;
        if (maxHit == 0) GameObject.DestroyObject(gameObject);
    }
    void testWin() {
        levelM.LoadNextScene();
    }
}
