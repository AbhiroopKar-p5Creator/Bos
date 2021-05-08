
using System;
using UnityEngine;
using UnityEngine.Assertions.Comparers;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private float _x;
    private float _z;
    private Vector3 _movement;
    
    private InputMaster _controls;
    private CharacterController _player;

    public float speed = 3f;
    private void Awake()
    {
     _controls = new InputMaster();
     _controls.Axis.Horizontal.performed += ctx => _x = ctx.ReadValue<float>();
     _controls.Axis.Vertical.performed += ctx => _z = ctx.ReadValue<float>();
    }

    private void Start()
    {
     _player = GetComponent<CharacterController>();
    }

    #region InputSystemSetup
    private void OnEnable()
    {
     _controls.Enable();
    }
    private void OnDisable()
    {
     _controls.Disable();
    }
    

    #endregion

    private void Update()
    {
     _movement = transform.right * _x + transform.forward * _z;
     _player.Move(_movement * speed * Time.deltaTime);
    }
}
