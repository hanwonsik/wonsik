using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public enum SOUNDTYPE
{
    BACKGROUND,
    EFFECT,
    SOUND_MAXCOUNT
};
public class SoundMgr : GenericSingleton<SoundMgr>
{
    float[] m_Volume = new float[(int)SOUNDTYPE.SOUND_MAXCOUNT];
    List<GameObject>[] m_ControlList = new List<GameObject>[(int)SOUNDTYPE.SOUND_MAXCOUNT];


    // UGUI 용
    [SerializeField]
    Slider[] m_Slider = new Slider[(int)SOUNDTYPE.SOUND_MAXCOUNT];

    void Update()
    {
        //  해당 슬라이드 바의 값이 변하면 볼륨을 설정시킨다.
        for (int i = 0; i < m_Slider.Length; ++i)
        {
            if (m_Slider[i] != null)
            {
                if (m_Slider[i].value != m_Volume[i])
                {
                    SetVolume((SOUNDTYPE)i, m_Slider[i].value);
                }
            }
        }
    }
    /// /////////////////////////////////////////////////////////////////////////////

    void Init()
    {
        //  초기화 ( 저장된 데이터 복원 )
        for (int i = 0; i < m_Volume.Length; ++i)
        {
            m_Volume[i] = 1;
            m_ControlList[i] = new List<GameObject>();
        }
    }
    //  관리 객체 추가하기
    public void AddObject(SOUNDTYPE _Type, GameObject _Obj)
    {
        m_ControlList[(int)_Type].Add(_Obj);
    }
    //  관리 객체 제거하기
    public void RemoveObject(SOUNDTYPE _Type, GameObject _Obj)
    {
        m_ControlList[(int)_Type].Remove(_Obj);
    }

    //  현재 볼륨 얻기
    public float GetVolume(SOUNDTYPE _Type)
    {
        return m_Volume[(int)_Type];
    }
    //  볼륨 설정하기
    public void SetVolume(SOUNDTYPE _Type, float _Volume)
    {
        m_Volume[(int)_Type] = Mathf.Clamp(_Volume, 0, 1);

        foreach (GameObject _obj in m_ControlList[(int)_Type])
        {
            AudioSource Audio = _obj.GetComponent<AudioSource>();
            Audio.volume = m_Volume[(int)_Type];
        }

        //  UGUI 용 설정
        if (m_Slider[(int)_Type] != null)
        {
            m_Slider[(int)_Type].value = m_Volume[(int)_Type];
        }
    }
}