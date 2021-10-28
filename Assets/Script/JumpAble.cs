using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAble : MonoBehaviour
{
    // Start is called before the first frame update
   [SerializeField] private float jumpforce = 10f;
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Platform"))

        {
            Debug.Log("Jump");

        Rigidbody2D rigidbody2d = gameObject.GetComponentInParent<Rigidbody2D>();
        rigidbody2d.AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);
        }
    }
}
