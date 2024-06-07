using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    public GameObject blocks;
    float timeStart;
    Vector2 randomPosition;
    void Start()
    {
        randomPosition = new Vector2(transform.position.x,Random.Range(-2,2));
        Instantiate(blocks, randomPosition, Quaternion.identity);
    }

    void Update()
    {
        timeStart += Time.deltaTime;
        if (timeStart >= 1)
        {
            randomPosition = new Vector2(transform.position.x, Random.Range(-2, 2));
            Instantiate(blocks, randomPosition, Quaternion.identity);
            timeStart = 0;
        }
    }
   
}
