using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bc : MonoBehaviour {

    public int force;
    private Rigidbody2D rbody;
    public GameObject Rect;
    public GameObject Rect2;
   
    private Color Color;
    public score s;
	// Use this for initialization
	void Start () {
        rbody = GetComponent<Rigidbody2D>();
        rbody.velocity = new Vector2(force,force);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "g")
        {
            if (transform.position.x < 0)
            {
                transform.position = Rect2.transform.position + new Vector3(-1f, 0, 0);
                rbody.velocity = new Vector2(-force, -force);
                s.UpdateScore(2);
            }
            else
            {
                transform.position = Rect.transform.position + new Vector3(1f, 0, 0);
                rbody.velocity = new Vector2(force, force);
                s.UpdateScore(1);
            }
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "rect1")
        {
            
            
                SpriteRenderer renderer = GetComponent<SpriteRenderer>();
                renderer.color = new Color(0.5f, 0.5f, 0.5f, 1f); // Set to opaque gray
            
         }
        if (collision.gameObject.tag == "rect2")
        {

          
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
            renderer.color = Color; 

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
    
        if (collision.gameObject.tag == "boundary"){
            int Colour = Random.Range(0, 3);
            
            if (Colour == 0)
            {
                Rect2.GetComponent<SpriteRenderer>().color = new Color(169, 0, 0);
                Color = new Color(169, 0, 0);
            }
            if (Colour == 1)
            {
                Rect2.GetComponent<SpriteRenderer>().color = new Color(35, 87, 137);
                Color = new Color(35, 87, 137);
            }
            if (Colour == 2)
            {
                Rect2.GetComponent<SpriteRenderer>().color = new Color(241, 211, 2);
                Color = new Color(241, 211, 2);
            }
            if (Colour == 3)
            {
                Rect2.GetComponent<SpriteRenderer>().color = new Color(69, 98, 65);
                Color = new Color(69, 98, 65);
            }

            //Rect2.GetComponent<SpriteRenderer>().color = new Color(69, 98, 65);
        }
    }


}
