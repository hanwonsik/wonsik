using UnityEngine;
using System.Collections;

public class SoundObject : MonoBehaviour {

    [SerializeField]
    SOUNDTYPE    m_SoundType;

	void Awake()
    {
        SoundMgr.Instance.AddObject(m_SoundType, gameObject);
	}
    void OnDestroy()
    {
        SoundMgr.Instance.RemoveObject(m_SoundType, gameObject);
    }
}
