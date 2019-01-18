using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddlescript : MonoBehaviour {
    private Vector2 start, end;
    public float fast;
    public float towards;
   

	
	// Update is called once per frame
	void Update () {

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            start = Input.GetTouch(0).position;
        }
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                end = Input.GetTouch(0).position;
                if ((end.y < start.y) && transform.position.y > -1.0f)
                {
                transform.position = new Vector3(transform.position.x, transform.position.y + (fast * Time.deltaTime), transform.position.z);
                towards = 1;

            }
                if ((end.y > start.y) && transform.position.y < -1.0f)
                {
                transform.position = new Vector3(transform.position.x, transform.position.y - (fast * Time.deltaTime), transform.position.z);
                towards = -1;


            }
        }
		
	}
}
