using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class settingSound : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Slider volumeSlider; 
    public GameObject settingMenu;
    public Button btnBack;

    private void Awake()
    {
        settingMenu.SetActive(false);
        btnBack.onClick.AddListener(onBackPressed);
    }

    public void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
        else
        {
            Load();
        }
    }

    void onBackPressed()
    {
        settingMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void changeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }
    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }
    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            settingMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
