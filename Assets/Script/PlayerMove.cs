using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    /// <summary>
    /// �v���C���[�̈ړ����x
    /// </summary>
    [SerializeField] float _movePower = 10;

    /// <summary>
    /// ���i���̃v���C���[�̈ړ����x
    /// </summary>
    [SerializeField] float _z = 10;

    /// <summary>
    /// �X�R�A�}�l�[�W���[�̎擾
    /// </summary>
    [SerializeField] GameObject _scoreManagerObject;

    //�v���C���[����������E�l
    private float _xLimit = 10;

    //�R�C���̃I�u�W�F�N�g
    private GameObject _coin = null;

    //�ړ��x�N�g��
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
        //�ړ�����

        Vector3 currentPos = transform.position;
        currentPos.x = Mathf.Clamp(currentPos.x, -_xLimit, _xLimit);
        transform.position = currentPos;
        //�ړ�����
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Stop")
        {
            _movePower = 0;
            _rb.constraints = RigidbodyConstraints.FreezeAll;
        }//�S�[���������̏���

        if (other.gameObject.tag == "Money")
        {
            _coin = other.gameObject;
            int plus = 10;
            _scoreManager.Score(plus);
            Destroy(_coin);
        }//�R�C���ɂԂ������Ƃ��̏���
    }
}
