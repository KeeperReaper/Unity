using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision) // This is when both object collide to each other
    {
        //SceneManager.LoadScene("Lose");
    }
    private void OnTriggerEnter2D(Collider2D collision) // This replaces collision if property trigger is ticked on(Trigger removes the collision bounce)
    {
        SceneManager.LoadScene("Lose");
    }
}
