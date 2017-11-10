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
        print(Input.mousePosition.x);
        paddlePosition.x = Mathf.Clamp((Input.mousePosition.x / Screen.width * 16) - 8, -7.36f, 7.36f);
        transform.position = paddlePosition;
        //    if (Input.GetKey(KeyCode.LeftArrow))
        //    {
        //        paddlePosition.x -= 0.2f;
        //        transform.position = paddlePosition;
        //    }
        //    if (Input.GetKey(KeyCode.RightArrow))
        //    {
        //        paddlePosition.x += 0.2f;
        //        transform.position = paddlePosition;
        //    }
    }
}
