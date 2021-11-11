using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public    PlayerController player;
    public  void Update()
    {
        gameObject.GetComponent<Text>().text = player.GetScore().ToString();
    }

}
