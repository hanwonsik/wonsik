using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GM : MonoBehaviour
{
    int count;
    int Leght;
    bool Mute;

    void Start()
    {}
    public void ChangeSound(bool Mute)
    {
        if(Mute == false)
        {
            Debug.Log("Vol Off");
            // AudioListener.pause = false;
            AudioListener.volume = 1;
            Mute = true;
        }
        else
        {
            Debug.Log("Vol On");
            // AudioListener.pause = true;
            AudioListener.volume = 0;
            Mute = false;
         }
     }
}
