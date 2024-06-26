using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead_car : MonoBehaviour
{
    public AudioSource crashSound;

    void Start()
    {

    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        healthControl.health -=1;
        if(healthControl.health == 0)
        {
            crashSound.Play();
            Destroy(gameObject);
            GameObject.Find("ScoreManager").GetComponent<ScoreManager>().GameOver();
        }
        
    }

    void Update()
    {
    
    }
}
