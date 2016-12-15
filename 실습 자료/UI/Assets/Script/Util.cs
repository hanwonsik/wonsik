using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Util : MonoBehaviour
{
    public void LoadScene(string _Name)
    {
        SceneManager.LoadScene(_Name);
    }
    public void UnLoadScene(string _Name)
    {
        SceneManager.UnloadScene(_Name);
    }
    public void PopupScene(string _Name)
    {
        SceneManager.LoadScene(_Name, LoadSceneMode.Additive);
    }
}