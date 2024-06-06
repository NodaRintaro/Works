using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    [SerializeField] GameObject _player = null;

    private Vector3 offset = default;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - _player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = _player.transform.position + offset;
    }
}
