using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlRodMap : MonoBehaviour {

    [SerializeField]
    private Image CR1,CR2,CR3,CR4,CR5,CR6,CR7;
    [SerializeField]
    private Transform CR1B;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void CR1ChangeColor()
    {
    CR1.color = new Color(0, 1, 0, 1);
    }
}
