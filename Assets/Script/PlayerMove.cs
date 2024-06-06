using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    /// <summary>
    /// プレイヤーの移動速度
    /// </summary>
    [SerializeField] float _movePower = 10;

    /// <summary>
    /// 直進時のプレイヤーの移動速度
    /// </summary>
    [SerializeField] float _z = 10;

    /// <summary>
    /// スコアマネージャーの取得
    /// </summary>
    [SerializeField] GameObject _scoreManagerObject;

    //プレイヤーがいける限界値
    private float _xLimit = 10;

    //コインのオブジェクト
    private GameObject _coin = null;

    //移動ベクトル
    Vector3 _dir = default;

    Rigidbody _rb;

    ScoreManager _scoreManager;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _scoreManager = _scoreManagerObject.GetComponent<ScoreManager>();
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        _dir = new Vector3(x, -1, _z);
        _rb.velocity = _dir * _movePower;
        //移動処理

        Vector3 currentPos = transform.position;
        currentPos.x = Mathf.Clamp(currentPos.x, -_xLimit, _xLimit);
        transform.position = currentPos;
        //移動制限
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Stop")
        {
            _movePower = 0;
            _rb.constraints = RigidbodyConstraints.FreezeAll;
        }//ゴールした時の処理

        if (other.gameObject.tag == "Money")
        {
            _coin = other.gameObject;
            int plus = 10;
            _scoreManager.Score(plus);
            Destroy(_coin);
        }//コインにぶつかったときの処理
    }
}
