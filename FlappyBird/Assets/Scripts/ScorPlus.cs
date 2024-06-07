using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorPlus : MonoBehaviour
{
    public GameObject scorPlus;
    public Text scorText;
    int sayac;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Block")
        {
            sayac++;
            scorText.text = sayac.ToString();
        }
    }
}
