using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{
    int frames = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola");
    }

    // Update is called once per frame
    void Update()
    {
        frames++;

        if (frames %100 == 0)
        {
            Debug.Log("100 frames mas");
        }
    }
}
