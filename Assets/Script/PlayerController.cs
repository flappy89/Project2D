using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1.0f;
    public float jumpforce = 1.0f;


   // [SerializeField] private float speed = 1.0f;
    [SerializeField] private int score = 0;

    Rigidbody2D rigidbody;

    public void AddScore()
    {
        score = score + 1;

    }

    public int GetScore()
    {
        return score;
    }

    public void start()
    {
          rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        Vector2 f = new Vector2(0,0);
        if(Input.GetKey(KeyCode.D))
        {
           f = new Vector2(speed,0);
        }
        else if(Input.GetKey(KeyCode.A))
        {
           f = new Vector2(-speed,0);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
           GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpforce),ForceMode2D.Impulse);
        }
       
       GetComponent<Rigidbody2D>().AddForce(f);
    }

}
