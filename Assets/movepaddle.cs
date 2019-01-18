using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movepaddle : MonoBehaviour {
    float miny, maxy;

	// Use this for initialization
	void Start () {
        Vector2 coord = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        miny = -coord.y + 0.3f;
        maxy = coord.y - 0.3f;

		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 temp = transform.position;
        if (temp.y > maxy)
        {
            temp.y = maxy;
        }
        if (temp.y < miny)
        {
            temp.y = miny;
        }
        transform.position = temp;
	}
}
