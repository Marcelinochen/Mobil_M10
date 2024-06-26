using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pauseEvent : MonoBehaviour
{
    public GameObject pauseMenu;
    public Button btnQuit; 

    private void Awake()
    {
        pauseMenu.SetActive(false);
        btnQuit.onClick.AddListener(onQuitPressed);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    

    void onQuitPressed()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
