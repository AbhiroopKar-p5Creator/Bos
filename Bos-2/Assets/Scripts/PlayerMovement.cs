
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
 public CharacterController playerBody;
    public float jumpHeight = 3f;
    public float speed = 6f;

    public float damping = -2f;
    public float gravity = -9.81f;


     public float x;
     public float z;

    private Vector3 velocity;
    const bool IsGrounded = true;
    
    private InputMaster _controls;

    private void Awake()
    {
     _controls = new InputMaster();
     _controls.Axis.Horizontal.performed += ctx => Variables(ctx.ReadValue<float>(),x);
     _controls.Axis.Vertical.performed += ctx => Variables(ctx.ReadValue<float>(),z);
    }

    #region InputSystemStup
    private static void Variables(float toGetVariable , float toSetVariable)
    {
     toSetVariable = toGetVariable;
    }

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
     if (IsGrounded && velocity.y < 0)
     {
      velocity.y = -2f;
     }

     // if(Input.GetKeyDown(KeyCode.Space) && IsGrounded){
     //  velocity.y = Mathf.Sqrt(jumpHeight * damping * gravity);
     // } 
    
     Vector3 playerMovement = (transform.right * x) + (transform.forward * z);
     velocity.y += gravity * Time.deltaTime;
    
     playerBody.Move(playerMovement * speed * Time.deltaTime);
     playerBody.Move(velocity * Time.deltaTime);
    }
}