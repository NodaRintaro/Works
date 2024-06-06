using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /// <summary>
    /// コインのゲームオブジェクト
    /// </summary>
    [SerializeField] GameObject _coin;

    //コインを生成
    Vector3 _insPos;

    void Start()
    {
        for (int i = 0; i < 90; i += 5)
        {
            float z = 0;
            z += i;
            _insPos = new Vector3(0, 1.5f, z);
            Instantiate(_coin, _insPos, Quaternion.identity);
        }//スタート時にコインを５mおきに生成する処理
    }
}
