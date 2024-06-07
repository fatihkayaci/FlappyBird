using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetyGame : MonoBehaviour
{
    public GameObject player;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(player, new Vector2(-2.2f, 0f), Quaternion.identity);
        }
    }
}
