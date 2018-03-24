using UnityEngine;

public class Mychara : MonoBehaviour
{
    public GameObject m_char1;
    void Start()
    {
    }

    void Update()
    {
        Vector3 v = m_char1.transform.localPosition;
        if (Input.GetKey(KeyCode.W))
        {   // Wキーで前進.
            v.z += 0.05f;
        }
        if (Input.GetKey(KeyCode.S))
        {   // Sキーで後退.
            v.z -= 0.05f;
        }
        if (Input.GetKey(KeyCode.A))
        {  // Aキーで左移動.
            v.x -= 0.05f;
        }
        if (Input.GetKey(KeyCode.D))
        {  // Dキーで右移動.
            v.x += 0.05f;
        }
        m_char1.transform.localPosition = v;
    }
}