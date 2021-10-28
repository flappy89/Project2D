using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1.0f;
    public float jumpforce = 1.0f;

    Rigidbody2D rigidbody;

    public void Start()
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
           rigidbody.AddForce(new Vector2(0, jumpforce),ForceMode2D.Impulse);
        }
       
       rigidbody.AddForce(f);
    }

}
