using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    public void LoadScene(string _Name)
    {
        SceneManager.LoadScene(_Name);        
    }
    public void UnLoadScene(string _Name)
    {
        SceneManager.UnloadScene(_Name);
    }
    public void PopUpScene(string _Name)
    {
        SceneManager.LoadScene(_Name, LoadSceneMode.Additive);
    }
}
