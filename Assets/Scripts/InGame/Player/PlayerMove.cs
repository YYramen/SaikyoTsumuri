using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �v���C���[�̈ړ��N���X
/// </summary>
public class PlayerMove : MonoBehaviour
{
    [SerializeField, Header("�ړ����x")]
    float _moveSpeed = 1f;

    Rigidbody _rb;
    float _inputX;
    float _inputZ;

    private void Start()
    {
        SetUp();
    }

    private void Update()
    {
        InputMove();
    }

    private void FixedUpdate()
    {
        Move();
    }

    void SetUp()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void InputMove()
    {
        _inputX = Input.GetAxisRaw("Horizontal");
        _inputZ = Input.GetAxisRaw("Vertical");
    }

    void Move()
    {
        _rb.AddForce(_inputX * _moveSpeed, 0, _inputZ * _moveSpeed, ForceMode.Impulse);
    }
}
