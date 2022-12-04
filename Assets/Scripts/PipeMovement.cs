using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    private float speed;  
    void Start()
    {
        Destroy(gameObject, 7.5f); 
        speed = 1.3f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * speed; 

    }
}
