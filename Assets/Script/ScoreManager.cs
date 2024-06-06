using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    //インスタンス
    private static ScoreManager _scoreInstance = new ScoreManager();

    /// <summary>
    /// スコアを表示するオブジェクト
    /// </summary>
    [SerializeField] GameObject _gameObject;

    //スコアの数値
    private int _score = 0;

    //テキストの取得
    Text _text;

    void Start()
    {
        _text = _gameObject.GetComponent<Text>();
        _text.text = _score.ToString("000");
    }//テキストの取得と最初の表示

    public static ScoreManager Instance()
    {
        return _scoreInstance;
    }

    public void Score(int score)
    {
        _score += score;
        _text.text = _score.ToString("000");
    }//スコアの加算処理
}
