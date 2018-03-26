using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class ControlRodMap : MonoBehaviour//,PointerDownHandler
{

    public Transform cube;
    
    // Use this for initialization
    void Start()
    {

    }
    /*public void OnPointerDown(PointerEventData _data)
    {
        Debug.Log("clicked");
        cube.Translate(0, 1, 0);
    }*/
    public void Clicne()
    {
        Debug.Log("OK");
    }
}