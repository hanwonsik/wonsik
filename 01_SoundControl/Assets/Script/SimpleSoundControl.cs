using UnityEngine;
using System.Collections;

public class SimpleSoundControl : MonoBehaviour {

    [SerializeField]
    string[] m_TagName = new string[(int)SOUNDTYPE.SOUND_MAXCOUNT];

    public void SetVolume(SOUNDTYPE _Type, float _Vol)
    {
        GameObject[] list = GameObject.FindGameObjectsWithTag(m_TagName[(int)_Type]);

        foreach( GameObject Obj in list )
        {
            AudioSource Audio = Obj.GetComponent<AudioSource>();

            if( Audio != null )
            {
                Audio.volume = _Vol;
            }
        }
    }
}