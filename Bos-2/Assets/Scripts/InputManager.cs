using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
  private Vector2 _movementInput;
  
  private InputMaster _inputMaster;
  private InputMaster.AxisActions _axis;

  [SerializeField] private PlayerMovement playerMovement;
  

  private void Awake()
  {
    _inputMaster = new InputMaster();
    _axis = _inputMaster.Axis;

    _axis.Movement.performed += ctx => _movementInput = ctx.ReadValue<Vector2>();
  }

  private void Update()
  {
    playerMovement.ReceiveInput(_movementInput);
  }

  #region InputSystemSetup
  private void OnEnable()
  {
    _inputMaster.Enable();
  }
  private void OnDisable()
  {
    _inputMaster.Disable();
  }

  private void OnDestroy()
  {
    _inputMaster.Disable();
  }

  #endregion
}
