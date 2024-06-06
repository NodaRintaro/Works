using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    /// <summary>
    /// �v���C���[�I�u�W�F�N�g�̎擾
    /// </summary>
    [SerializeField] GameObject _player = null;

    //�v���C���[�ƃJ�����̋���
    private Vector3 offset = default;

    void Start()
    {
        offset = transform.position - _player.transform.position;
    }//�X�^�[�g���Ƀv���C���[�ƃJ�����̋������擾

    void Update()
    {
        transform.position = _player.transform.position + offset;
    }//�v���C���[�ƃJ�����̋�����ۂ�������
}
