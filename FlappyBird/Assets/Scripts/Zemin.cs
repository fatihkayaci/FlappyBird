using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zemin : MonoBehaviour
{

    const float speed = 3f;
    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
