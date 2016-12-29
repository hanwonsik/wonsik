using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GenericSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static object m_SyncRoot = new object();
    private static T m_Instance = null;
    public static T Instance
    {
        get
        {
            if (m_Instance == null)
            {
                lock (m_SyncRoot)
                {
                    if (m_Instance == null)
                    {
                        //  해당 스크립트를 찾는다.
                        m_Instance = FindObjectOfType<T>();

                        if (m_Instance == null)
                        {
                            GameObject Obj = new GameObject();
                            Obj.name = "Singleton : " + typeof(T).ToString();

                            m_Instance = Obj.AddComponent<T>();
                        }

                        //  Init 메서드 호출
                        m_Instance.SendMessage("Init", SendMessageOptions.DontRequireReceiver);

                        //  씬전환시 객체 유지
                        DontDestroyOnLoad(m_Instance);
                    }
                }
            }
            return m_Instance;
        }
    }
    protected void Awake()
    {
        if (FindObjectsOfType<T>().Length > 1)
        {
            Destroy(gameObject);
        }
    }
}

