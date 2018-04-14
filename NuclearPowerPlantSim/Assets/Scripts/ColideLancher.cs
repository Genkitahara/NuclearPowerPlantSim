using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColideLancher : MonoBehaviour {

    private  static ControlRodDrive RodDrive;
    public new Camera camera;
    public GameObject SQButton;
    public GameObject SQCancelButton;

    private Image test;
    RaycastHit hit;

    private int i;

    // Use this for initialization
    void Start () {
        SQButton = GameObject.Find("SQ");
        SQCancelButton = GameObject.Find("SQ2");
        RodDrive = gameObject.AddComponent<ControlRodDrive>();
    }
	
	// Update is called once per frame
	void Update () {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                Debug.Log(hit.collider.gameObject.name);
                if (hit.collider.gameObject.name == "SQ") RodDrive.ControlRodInsertStart();
                if (hit.collider.gameObject.name == "SQ2") RodDrive.ControlRodPullOutStart();
            }
        }
 
    }
}
