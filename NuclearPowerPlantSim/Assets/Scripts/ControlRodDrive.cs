using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlRodDrive : MonoBehaviour {

    public static Image[] ControlRods;
    private Color RodInsertColor, RodPulloutColor,RodActivatingColor;

    private int i;

    private float CountTime;
    private float TargetTime;
    private bool isTimer = false;
    private bool isSQ = false;


    // Use this for initialization
    void Start () {
        ControlRods = new Image[205];
        for (i = 1; i < 206; i++) ControlRods[i - 1] = GameObject.Find("Rod" + i).GetComponent<Image>();
        RodInsertColor = new Color(0, 1, 0, 1);
        RodPulloutColor = new Color(1, 1, 1, 1);
        RodActivatingColor = new Color(1, 1, 0, 1);
    }
	
	// Update is called once per frame
	void Update () {
        if (isTimer) CountTime += Time.deltaTime;
        //Debug.Log(CountTime);
        if(CountTime > 4)
        {
            if (isSQ) for (i = 0; i < 205; i++) ControlRods[i].color = RodInsertColor;
            else for (i = 0; i < 205; i++) ControlRods[i].color = RodPulloutColor;
            CountTime = 0;
        }
    }

    public void ControlRodInsertStart()
    {
        for (i = 0; i < 205; i++) ControlRods[i].color = RodActivatingColor;
        isSQ = true;
    }
    public void ControlRodPullOutStart()
    {
        for (i = 0; i < 205; i++) ControlRods[i].color = RodActivatingColor;
        isSQ = false;
    }
}
