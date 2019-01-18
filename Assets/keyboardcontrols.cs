using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboardcontrols : MonoBehaviour {
    public float fast;
    public float towards;
    public float paddlehitspeed;
    public bool player1;
    public bool paddleai;
    public bc bc;
   
	// Use this for initialization
	void Start () {
        bc = FindObjectOfType<bc>();
	}
	
	// Update is called once per frame
	void Update () {
        if (paddleai)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, bc.transform.position.y, transform.position.z),fast*Time.deltaTime);
        }
        else
        {
            if (player1)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y + (fast * Time.deltaTime), transform.position.z);
                    towards = 1;
                }
                else if (Input.GetKey(KeyCode.S))
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y - (fast * Time.deltaTime), transform.position.z);
                    towards = -1;

                }
                else
                {
                    towards = -2;
                }
            }
            else
            {
                if (Input.GetKey(KeyCode.O))
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y + (fast * Time.deltaTime), transform.position.z);
                    towards = 1;
                }
                else if (Input.GetKey(KeyCode.L))
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y - (fast * Time.deltaTime), transform.position.z);
                    towards = -1;

                }
                else
                {
                    towards = 0;
                }

            }
        }
        if (transform.position.y > 4)
        {
            transform.position = new Vector3(transform.position.x, 4, transform.position.z);
        }
        else if (transform.position.y < -4)
        {
            transform.position = new Vector3(transform.position.x, -4, transform.position.z);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.rigidbody.velocity = new Vector2(collision.rigidbody.velocity.x*1.2f, collision.rigidbody.velocity.y + (towards*paddlehitspeed));
    }
   
}
