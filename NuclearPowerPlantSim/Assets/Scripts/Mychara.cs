//使うシステムの宣言(？)
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//クラス
public class Mychara : MonoBehaviour
{

    public Transform CamPos;
    //public Transform Player;
    private Vector3 Camforward;
    private Vector3 ido;
    private Vector3 Animdir = Vector3.zero;
    public float distance = 12.0f;
    public float xSpeed = 250.0f;
    public float ySpeed = 120.0f;
    public float yMinLimit = -45f;
    public float yMaxLimit = 85f;
    private float x = 0.0f;
    private float y = 0.0f;
    float inputHorizontal;
    float inputVertical;
    bool isSelectMode = false;
    public float runspeed;

    void Start()
    {
        var angles = CamPos.eulerAngles;
        x = angles.y;
        y = angles.x;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        //Cursor.visible = true;
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");
        x += Input.GetAxis("Mouse X") * xSpeed * 0.02f;
        y -= Input.GetAxis("Mouse Y") * ySpeed * 0.02f;

        y = ClampAngle(y, yMinLimit, yMaxLimit);

        var rotation = Quaternion.Euler(y, x, 0);
        if(!isSelectMode)CamPos.rotation = rotation;

        /*if (Input.GetKeyUp(KeyCode.Q))
        {
            if (Cursor.lockState == CursorLockMode.Locked) {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                isSelectMode = true;
            }
            else {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                isSelectMode = false;
            }
        }*/
        
    }

    private void FixedUpdate()
    {
 
    }

    static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360) { angle += 360; }
        if (angle > 360) { angle -= 360; }
        return Mathf.Clamp(angle, min, max);
    }
}