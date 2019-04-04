using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public void StartGame()
    {
        SceneManager.LoadScene("GameWithUI");
    }

    public void BackToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public GameObject pausemenu;
    public bool ispaused;


    public void ResumeGame()
    {
        ispaused = false;
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (ispaused)
            {
                ResumeGame();
            }
            else
            {
                ispaused = true;
                pausemenu.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }


    public GameObject ResolutionPanel;
    public void OpenOptions()
    {
        ResolutionPanel.SetActive(true);
    }
    public int width;
    public int height;
    public void SetWidth(int newwidth){
        width = newwidth;
    }
    public void SetHeight(int newheight)
    {
        height = newheight;
    }
    public void SetRes()
    {
        Screen.SetResolution(width, height, false);
    }


    
}
