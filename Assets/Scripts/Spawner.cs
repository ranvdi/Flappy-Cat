using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pipe;
    public float timer;
    private float baseTimer;
    public float height; 

    void Start()
    {
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        baseTimer = timer; 
    }

    void Update()
    {

        timer -= Time.deltaTime;

        if(timer <0)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            timer = baseTimer;
        }
            
            
    }
}
