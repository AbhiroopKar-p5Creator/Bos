using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseRotate : MonoBehaviour
{
	[Range(0f, 100f)] public float mouseSensitivity = 15;
    public Transform playerBody;

    private float _xRotation = 0f;
    private float _mouseX;
    private float _mouseY; 

    private InputMaster _controls;

    private void Awake()
    {
	    _controls = new InputMaster();
	    _controls.Axis.MouseX.performed += ctx =>_mouseX = ctx.ReadValue<float>();
	    _controls.Axis.MouseY.performed += ctx =>_mouseY = ctx.ReadValue<float>();
    }

    private void Start()
    {
	    Cursor.lockState = CursorLockMode.Locked;  
    }
		
 
 	private void Update(){
	    
	 _xRotation -= _mouseY * mouseSensitivity * Time.deltaTime;
     _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);
    
     this.transform.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);
     playerBody.Rotate(Vector3.up * _mouseX * mouseSensitivity * Time.deltaTime);
 
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

}
