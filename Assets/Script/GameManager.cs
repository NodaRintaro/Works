using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /// <summary>
    /// �R�C���̃Q�[���I�u�W�F�N�g
    /// </summary>
    [SerializeField] GameObject _coin;

    //�R�C���𐶐�
    Vector3 _insPos;

    void Start()
    {
        for (int i = 0; i < 90; i += 5)
        {
            float z = 0;
            z += i;
            _insPos = new Vector3(0, 1.5f, z);
            Instantiate(_coin, _insPos, Quaternion.identity);
        }//�X�^�[�g���ɃR�C�����Tm�����ɐ������鏈��
    }
}
