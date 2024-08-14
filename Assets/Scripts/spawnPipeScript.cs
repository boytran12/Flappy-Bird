using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPipeScript : MonoBehaviour
{
    public GameObject pipe;

    public float timer = 0;
    public float spawnRate = 2;
    public float heightOffset = 10;
    

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();

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
            
            spawnPipe();

            timer = 0;
        }

    }


    void spawnPipe()
    {
        float lowestPont = transform.position.y - heightOffset;
        float highestPont = transform.position.y + heightOffset;


        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPont, highestPont), 0), transform.rotation);
    }

}
