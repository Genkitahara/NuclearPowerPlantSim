//このコードをゲーム開始時に最初に読み込むスクリプトファイル（プレイヤー系やタイトル系など）に追記する。画面サイズはスクリプトをアタッチされたオブジェクトのインスペクター上で指定

using UnityEngine;
using System.Collections;
public class StartAwake : MonoBehaviour
{ //xxxxにはスクリプト自体のファイル名が入る

    [SerializeField]
    //　ポーズした時に表示するUI
    public int ScreenWidth;
    public int ScreenHeight;


    void Awake()
    {
        // PC向けビルドだったらサイズ変更
        if (Application.platform == RuntimePlatform.WindowsPlayer ||
        Application.platform == RuntimePlatform.OSXPlayer ||
        Application.platform == RuntimePlatform.LinuxPlayer)
        {
            Screen.SetResolution(ScreenWidth, ScreenHeight, false);
            Screen.fullScreen = true;
        }
    }
    void Update()
    {
        
    }
}
