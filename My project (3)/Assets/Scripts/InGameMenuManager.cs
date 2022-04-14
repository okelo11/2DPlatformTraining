using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class InGameMenuManager : MonoBehaviour
{
    public GameObject inGameScreen, pauseScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PauseButto()
    {
        Time.timeScale = 0;
        inGameScreen.SetActive(false);
        pauseScreen.SetActive(true);
    }
    public void ResumeButton()
    {
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
        inGameScreen.SetActive(true);
    }
    public void ReplayButton()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void HomeButton()
    {
        SceneManager.LoadScene(0);
        
    }
}
