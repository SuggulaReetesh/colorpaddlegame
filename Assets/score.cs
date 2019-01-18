using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {
    public int tobescored;
    public Text scored;
    private int playerscore;
    private int enemyscore;
    public Text wintext;
    public GameObject ball;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (playerscore >= tobescored)
        {
            wintext.gameObject.SetActive(true);
            wintext.text = "Player 1 wins";
            ball.SetActive(false);

        }
        if (enemyscore >= tobescored)
        {
            wintext.gameObject.SetActive(true);
            wintext.text = "Player 2 wins";
            ball.SetActive(false);

        }

    }

    public void UpdateScore(int player)
    {
        if (player == 1)
        {
            playerscore += 1;
        }
        if (player == 2)
        {
            enemyscore += 1;
        }
        scored.text = playerscore + "                                                   " + enemyscore;
    }
}
