using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 _groundMovement;
    private Vector3 _verticalMovement;
    private Vector2 _movementInput;

    public float gravity = 9.81f;
    private bool _isGrounded;
    private LayerMask _ground;
    

    private CharacterController _player;

    

    public float speed = 3f;

    private void Start()
    { _ground =  LayerMask.GetMask("Ground");
     _player = GetComponent<CharacterController>();
    }


    public void ReceiveInput(Vector2 input)
    {
        _movementInput = input;

    }
    
    private void Update()
    {
        _isGrounded = UnityEngine.Physics.CheckSphere(transform.position, 1f, _ground);   
        
     _groundMovement = (transform.right * _movementInput.x + transform.forward * _movementInput.y) * speed;
     _player.Move(_groundMovement * Time.deltaTime);

     _verticalMovement.y += -gravity * Time.deltaTime; 
  
     
     if (_isGrounded == true){ _verticalMovement.y = 0f; }
     _player.Move(_verticalMovement);
    }
}