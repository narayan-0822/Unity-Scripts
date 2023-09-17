using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class PauseGame : MonoBehaviour {
    public Transform canvas;
    public Transform pauseMenu;
    public Transform soundsMenu;
    public Transform videoSettingsMenu;
    public Transform controlsMenu;
    public Transform Player;
    SaveGame saveGame;



	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
	}
    public void Pause()
    {
        if (canvas.gameObject.activeInHierarchy == false)
        {
            if (pauseMenu.gameObject.activeInHierarchy == false)
            {
                pauseMenu.gameObject.SetActive(true);
                soundsMenu.gameObject.SetActive(false);
                videoSettingsMenu.gameObject.SetActive(false);
                controlsMenu.gameObject.SetActive(false);
            }
            canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
            Player.GetComponent<FirstPersonController>().enabled = false;
            saveGame = gameObject.GetComponent<SaveGame>();
            saveGame.SaveGameSettings(false);
        }
        else
        {
            canvas.gameObject.SetActive(false);
            Time.timeScale = 1;
            Player.GetComponent<FirstPersonController>().enabled = true;
        }
    }

    public void Sounds(bool Open)
    {
        if (Open)
        {
            soundsMenu.gameObject.SetActive(true);
            pauseMenu.gameObject.SetActive(false);
        }
        if (!Open)
        {
            soundsMenu.gameObject.SetActive(false);
            pauseMenu.gameObject.SetActive(true);
        }
    }


    public void VideoSettings(bool Open)
    {
        if (Open)
        {
            videoSettingsMenu.gameObject.SetActive(true);
            pauseMenu.gameObject.SetActive(false);
        }
        if (!Open)
        {
            videoSettingsMenu.gameObject.SetActive(false);
            pauseMenu.gameObject.SetActive(true);
        }
    }


    public void Controls(bool Open)
    {
        if (Open)
        {
            controlsMenu.gameObject.SetActive(true);
            pauseMenu.gameObject.SetActive(false);
        }
        if (!Open)
        {
            controlsMenu.gameObject.SetActive(false);
            pauseMenu.gameObject.SetActive(true);
        }
    }
}
