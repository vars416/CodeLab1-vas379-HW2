using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score_Script : MonoBehaviour
{
    public Text Score1;
    public int ScoreValue1 = 0;
    public Text Score2;
    public int ScoreValue2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        Score1 = GetComponent<Text>();
        Score2 = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Score1.text = "P1 = " + ScoreValue1;
        Score2.text = "P2 = " + ScoreValue2;
    }
}
