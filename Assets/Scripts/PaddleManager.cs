using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleManager : MonoBehaviour {

    Vector3 paddlePosition;
	// Use this for initialization
	void Start () {
        paddlePosition = transform.position;

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            paddlePosition.x--;
            transform.position = paddlePosition;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            paddlePosition.x++;
            transform.position = paddlePosition;
        }
    }
}
