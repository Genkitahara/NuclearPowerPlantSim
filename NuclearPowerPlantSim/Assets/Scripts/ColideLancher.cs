using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColideLancher : MonoBehaviour {

    public new Camera camera;
    public GameObject SQButton;
    public GameObject SQCancelButton;

    public Image[] ControlRods;
    private Color RodInsertColor,RodPulloutColor;
    private Image test;
    RaycastHit hit;

    private int i;

    // Use this for initialization
    void Start () {
        SQButton = GameObject.Find("SQ");
        SQCancelButton = GameObject.Find("SQ2");
        for (i = 1; i < 206; i++)ControlRods[i-1] = GameObject.Find("Rod" + i).GetComponent<Image>();
        RodInsertColor = new Color(0, 1, 0, 1);
        RodPulloutColor = new Color(1, 1, 1, 1);
    }
	
	// Update is called once per frame
	void Update () {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                Debug.Log(hit.collider.gameObject.name);
                if (hit.collider.gameObject.name == "SQ")   for (i = 0; i < 205; i++) ControlRods[i].color = RodInsertColor;
                if (hit.collider.gameObject.name == "SQ2") for (i = 0; i < 205; i++) ControlRods[i].color = RodPulloutColor;
            }
        }
 
    }
}
