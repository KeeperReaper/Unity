using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour {

    public PaddleManager Paddle;
    Rigidbody2D rb;
    // Use this for initialization
    void Start () {
        Paddle = GameObject.FindObjectOfType<PaddleManager>();
        rb = this.GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Static;
    }
	
	// Update is called once per frame
	void Update () {
        if (rb.bodyType == RigidbodyType2D.Static) {
            this.transform.position = new Vector3(Paddle.transform.position.x, this.transform.position.y, 0);
        }
        if (Input.GetMouseButtonDown(0) && rb.bodyType == RigidbodyType2D.Static) {
            rb.bodyType = RigidbodyType2D.Dynamic;
            rb.velocity = new Vector2(10f, 10f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().Play();
    }
}
