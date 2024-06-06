using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    //�C���X�^���X
    private static ScoreManager _scoreInstance = new ScoreManager();

    /// <summary>
    /// �X�R�A��\������I�u�W�F�N�g
    /// </summary>
    [SerializeField] GameObject _gameObject;

    //�X�R�A�̐��l
    private int _score = 0;

    //�e�L�X�g�̎擾
    Text _text;

    void Start()
    {
        _text = _gameObject.GetComponent<Text>();
        _text.text = _score.ToString("000");
    }//�e�L�X�g�̎擾�ƍŏ��̕\��

    public static ScoreManager Instance()
    {
        return _scoreInstance;
    }

    public void Score(int score)
    {
        _score += score;
        _text.text = _score.ToString("000");
    }//�X�R�A�̉��Z����
}
