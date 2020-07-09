using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private CharacterController _PlayerController;

    private Vector3 _PlayerDirection = new Vector3(0.0f, 0.0f, 0.0f);

    private float _MoveSpeed = 6.0f;


    private void Start()
    {
        Initialize();
    }

    private void Update()
    {
        MovePlayer();
    }


    private void Initialize()
    {
        _PlayerController = gameObject.AddComponent<CharacterController>();
    }

    private void MovePlayer()
    {
        _PlayerDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        _PlayerController.Move(_PlayerDirection * Time.deltaTime * _MoveSpeed);
    }

}
