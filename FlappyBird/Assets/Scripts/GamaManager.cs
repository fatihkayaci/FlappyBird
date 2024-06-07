using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamaManager : MonoBehaviour
{
    public GameObject zemin;
    public GameObject gameOver;
    public GameObject blockManager;
    float timeStart;
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            gameOver.SetActive(true);
            blockManager.SetActive(false);
            Destroy(GameObject.FindGameObjectWithTag("Block"));
        }
        else
        {
            gameOver.SetActive(false);
            blockManager.SetActive(true);
        }

        timeStart += Time.deltaTime;

        if (timeStart >= 0.87f)
        {
            Instantiate(zemin, new Vector2(transform.position.x,-4.6f), Quaternion.identity);
            timeStart = 0;
        }
    }
}
