using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorInimigos : MonoBehaviour
{
    [SerializeField]
    private GameObject prefabInimigo;
    [SerializeField]
    private GameObject prefabInimigoAtirador;
    [SerializeField]
    private float maxTime = 1;
    private float timeIcre = 0;

    //private float x = 2;
    //private float y = 8;

    void Update()
    {
        timeIcre += Time.deltaTime;
        if(timeIcre >= maxTime)
        {
            var x = Random.Range(-10.8f, 10.9f);
            Instantiate(prefabInimigo, new Vector2(x, 6.3f), transform.rotation);
            timeIcre= 0;

            var b = Random.Range(-10.8f, 10.9f);
            Instantiate(prefabInimigoAtirador, new Vector2(x, 6.3f), transform.rotation);
            timeIcre = 0;
        }
    }

    void NovosInimigos()
    {
        Instantiate(prefabInimigo, new Vector3(Random.Range(-2, 4), 5, 0), transform.rotation);
        Instantiate(prefabInimigoAtirador, new Vector3(Random.Range(-4, 2), 8, 0), transform.rotation);
    }

}
