using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Car : MonoBehaviour
{
    float lastSpawn = 0.0f;
    public float Cooldown = 2f;
    public GameObject Blueprint;

    void Update(){
        if (Time.time >= lastSpawn + Cooldown){
            // Spawn car
            var go = Instantiate(Blueprint, new Vector2(Random.Range(-2.6f, 2.6f), transform.position.y), Blueprint.transform.rotation);
            lastSpawn = Time.time;
        }
    }
}
