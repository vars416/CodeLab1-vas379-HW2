using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float force = 5;
    Rigidbody2D rb;
    public GameObject diamond;
    public int score = 0;
    public static PlayerController instance; //make this a singleton

    private void Awake()
    {
        if (instance == null)
        {
            instance = this; //set instance to this object
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

        /*rb.AddForce(Vector2.right * force);*/
    }

    // Update is called once per frame
    void Update()
    {

/*        if (gameObject.CompareTag("Ply1"))
        {
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(Vector2.right * force);
            }

            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(Vector2.left * force);
            }

            if (Input.GetKey(KeyCode.W))
            {
                rb.AddForce(Vector2.up * force);
            }

            if (Input.GetKey(KeyCode.S))
            {
                rb.AddForce(Vector2.down * force);
            }
        }*/

        if (gameObject.CompareTag("Ply2"))
        {
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(Vector2.right * force);
            }

            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(Vector2.left * force);
            }

            if (Input.GetKey(KeyCode.W))
            {
                rb.AddForce(Vector2.up * force);
            }

            if (Input.GetKey(KeyCode.S))
            {
                rb.AddForce(Vector2.down * force);
            }
        }
    }
}
