using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideButton : MonoBehaviour {
    public Transform form;
    public Animator InformationAnimator;
    public Animator AlertAnimatior;

    // Use this for initialization
    void Start () {
        /*obj = GameObject.Find("unitychan");
        anim = obj.GetComponent<Animator>();*/
        //animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftShift))InformationAnimator.SetBool("isHide", !InformationAnimator.GetBool("isHide"));
        if (Input.GetKeyDown(KeyCode.LeftControl)) AlertAnimatior.SetBool("isHide", !AlertAnimatior.GetBool("isHide"));

    }
    public void InformationPressd()
    {
        InformationAnimator.SetBool("isHide", !InformationAnimator.GetBool("isHide"));
    }
    public void AlertPressd()
    {
        AlertAnimatior.SetBool("isHide", !AlertAnimatior.GetBool("isHide"));
    }

}
