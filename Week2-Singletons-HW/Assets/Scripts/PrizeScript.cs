﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrizeScript : MonoBehaviour
{

    public static int CurrentLevel = 0;
    public int Target;

/*    public Text Score1;
    public Text Score2;
    public int ScoreValue1;
    public int ScoreValue2;*/

    // Start is called before the first frame update
    void Start()
    {
        Target = PlayerController.instance.score * 1 + 5;
    }

    // Update is called once per frame
    void Update()
    {
/*        Score1.text = ScoreValue1.ToString();
        Score2.text = ScoreValue2.ToString();*/
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        transform.position = new Vector2(Random.Range(-6, 6), Random.Range(-4, 4));

        /*if (collision.gameObject.tag == "Ply1")
        {
            ScoreValue1 += 1;
        }*/

        if (collision.gameObject.tag == "Ply2")
        {
            //ScoreValue2 += 1;
            PlayerController.instance.score++;
        }

        if (PlayerController.instance.score > Target) //if the current score >  the targetScore
        {
            CurrentLevel++; //increate the level number
            SceneManager.LoadScene(CurrentLevel); //go to the next level
        }
    }

}
