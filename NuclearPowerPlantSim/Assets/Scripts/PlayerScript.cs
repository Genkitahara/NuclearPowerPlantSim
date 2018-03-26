using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    float inputHorizontal;
    float inputVertical;
    Rigidbody rb;
    public Transform camera;
    public Transform player;

    public float moveSpeed = 3f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        // カメラの方向から、X-Z平面の単位ベクトルを取得
        Vector3 cameraForward = Vector3.Scale(camera.forward, new Vector3(1, 0, 1)).normalized;

        //player.rotation = Quaternion.LookRotation(camera.forward);

        //Debug.Log(cameraForward);

        // 方向キーの入力値とカメラの向きから、移動方向を決定
        Vector3 moveForward = cameraForward * inputVertical + camera.right * inputHorizontal;

        //Debug.Log(moveForward);

        // 移動方向にスピードを掛ける。ジャンプや落下がある場合は、別途Y軸方向の速度ベクトルを足す。
        rb.velocity = moveForward * moveSpeed + new Vector3(0, rb.velocity.y, 0);

        //Debug.Log(rb.velocity);

        // キャラクターの向きを進行方向に
       // if (moveForward != Vector3.zero)
       // {
          
       // }
    }
}
