using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthControl : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject life01, life02, life03;
    public static int health;
    void Start()
    {
        health = 3;
        life01.gameObject.SetActive(true); 
        life02.gameObject.SetActive(true); 
        life03.gameObject.SetActive(true); 
    }

    // Update is called once per frame
    void Update()
    {
        switch (health)
        {
            case 3:
                life01.gameObject.SetActive(true);
                life02.gameObject.SetActive(true);
                life03.gameObject.SetActive(true);
                break;
            case 2:
                life01.gameObject.SetActive(true);
                life02.gameObject.SetActive(true);
                life03.gameObject.SetActive(false);
                break;
            case 1:
                life01.gameObject.SetActive(true);
                life02.gameObject.SetActive(false);
                life03.gameObject.SetActive(false);
                break;
            case 0:
                life01.gameObject.SetActive(false);
                life02.gameObject.SetActive(false);
                life03.gameObject.SetActive(false);
                break;
        }
    }
}
