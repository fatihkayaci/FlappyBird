using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamaManager : MonoBehaviour
{
    public GameObject zemin;
    public GameObject gameOver;
    public GameObject blockManager;
    public GameObject start;
    public GameObject player;
    private bool hasStarted = false;
    float timeStart;
    private void Awake()
    {
        blockManager.SetActive(false);
        gameOver.SetActive(false);
        
    }
    void Update()
    {
        if (!hasStarted && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(player, new Vector2(-1.5f, 0f), Quaternion.identity);
            start.SetActive(false);
            blockManager.SetActive(true);
            hasStarted = true;
        }

        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            if (start.activeSelf)
            {
                gameOver.SetActive(false);
            }
            else
            {
                gameOver.SetActive(true);
            }
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
            Instantiate(zemin, new Vector2(transform.position.x, -4.6f), Quaternion.identity);
            timeStart = 0;
        }
    }
}
