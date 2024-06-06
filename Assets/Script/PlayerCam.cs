using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    /// <summary>
    /// プレイヤーオブジェクトの取得
    /// </summary>
    [SerializeField] GameObject _player = null;

    //プレイヤーとカメラの距離
    private Vector3 offset = default;

    void Start()
    {
        offset = transform.position - _player.transform.position;
    }//スタート時にプレイヤーとカメラの距離を取得

    void Update()
    {
        transform.position = _player.transform.position + offset;
    }//プレイヤーとカメラの距離を保ち続ける
}
