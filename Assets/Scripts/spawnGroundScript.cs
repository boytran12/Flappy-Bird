using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnGroundScript : MonoBehaviour
{
    public GameObject ground;

    public float timer = 0;
    public float spawnRate = 2;


    // Start is called before the first frame update
    void Start()
    {
        spawnGround();

    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;

        }
        else
        {

            spawnGround();
            timer = 0;
        }

    }


    void spawnGround()
    {
       
        Instantiate(ground,transform);
    }

}
