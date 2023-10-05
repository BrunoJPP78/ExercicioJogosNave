using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroInimigo : MonoBehaviour
{
    public GameObject prefabLaser;

    public float timerShot;


    void Start()
    {
        timerShot = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerShot == 60)
        {
            Instantiate(prefabLaser, transform.position + new Vector3(0, -1f, 0), transform.rotation);
            timerShot = 0;
        }
        else
        {
            timerShot++;
        }

    }
}

