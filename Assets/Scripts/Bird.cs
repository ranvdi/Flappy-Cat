using System.Collections;
using System.Collections.Generic;
using UnityEngine;
  
public class Bird : MonoBehaviour
{
    public bool isDead; 
       
    public float velocity = 1f;
    public Rigidbody2D rb2D;
    public AudioSource seskontrol;
    public AudioClip olumsesi; 
    public GameManager managerGame;
    public GameObject DeathScreen;

    private void Start()
    {
        seskontrol = GetComponent<AudioSource>(); 
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb2D.velocity = Vector2.up * velocity;
        }
         
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Score" )
        {
            managerGame.UpdateScore(); 
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathArea")
        {
            seskontrol.PlayOneShot(olumsesi);   
            isDead = true;
            Time.timeScale = 0;

            DeathScreen.SetActive(true); 
        }
    }
}
 