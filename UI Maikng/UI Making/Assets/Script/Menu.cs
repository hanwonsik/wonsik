using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject mainMenuHolder;
    public GameObject OptionMenuHolder;

    public Slider[] volumeSlider;
    public void Play()
    {
        SceneManager.LoadScene("Game");
    }
    public void Quit()
    {
        Application.Quit();
    }
	
    public void Option()
    {
        mainMenuHolder.SetActive(false);
        OptionMenuHolder.SetActive(true);
    }
    public void MainMenu()
    {
        mainMenuHolder.SetActive(true);
        OptionMenuHolder.SetActive(false);

    }
    public void SetMasterVolume(float value)
    {
      
    }
    public void SetEffectVolume(float value)
    {

    }
}
