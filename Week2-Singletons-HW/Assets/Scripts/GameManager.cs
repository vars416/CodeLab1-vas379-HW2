using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public Text ScoreKeeper;
    public float timer = 30;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this; //instance is set to this particular object
            DontDestroyOnLoad(gameObject); //Don't destroy this object
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        GetComponentInChildren<Text>(); 
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime; //decrease the time using time.delta time
        ScoreKeeper.text = "Score: " + PlayerController.instance.score + " Time: " + (int)timer; //show time and score as text

        if ((int)timer == 0) 
        {
            SceneManager.LoadScene(4); //change scene when timer runs out
            Destroy(PlayerController.instance.gameObject); //destroy player (Works, but shows some error)
        }

        if (PlayerController.instance.score == 18)
        {
            Destroy(ScoreKeeper); //on reaching win screen, destroy timer and plalyer
            Destroy(PlayerController.instance.gameObject);
        }
    }
}
