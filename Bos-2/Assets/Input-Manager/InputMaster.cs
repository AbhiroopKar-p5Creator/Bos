// GENERATED AUTOMATICALLY FROM 'Assets/Input-Manager/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Axis"",
            ""id"": ""d5366602-1f73-4f0d-bc81-120bd58f995e"",
            ""actions"": [
                {
                    ""name"": ""MouseX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""17273dbd-37cf-4733-ba9c-e6100c5f25cc"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d8a18327-8da5-47ad-b752-0669da9179fe"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f5715ce6-a405-4ddc-b6a2-563e83a1e156"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""fffda2ad-3804-4c23-a21b-b80aeeff1998"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2d4f07cd-3207-44c3-b28f-c33aefde186f"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""MouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""77afaa12-887b-4faa-81f5-63e0ff6a79af"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""MouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keys"",
                    ""id"": ""fd71713c-c6c7-43d5-86b3-6397337aa8b2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e7080c1d-bc72-4d02-8096-daeee328d1f1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""37b04781-a4c2-466c-91e0-5aea3d21c480"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""29828614-2390-4e47-a363-50feca8f1c7e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""aa0a585a-ae5a-4ef8-82ef-37011a5f0f30"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""1e15fcdb-df3a-46d7-a70c-acad0bda369d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""78488ac5-2e7b-4630-b4c4-deb7862b087a"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""de58aae4-65cd-4a3e-99fe-3dc63932f115"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3a38a74a-5d2e-4fde-9caa-69568556393a"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8d61910f-8ca8-44ba-a26f-2574286dba56"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f8b3d743-6b38-4acc-90a5-85e65a474fb7"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Controller"",
            ""bindingGroup"": ""Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Axis
        m_Axis = asset.FindActionMap("Axis", throwIfNotFound: true);
        m_Axis_MouseX = m_Axis.FindAction("MouseX", throwIfNotFound: true);
        m_Axis_MouseY = m_Axis.FindAction("MouseY", throwIfNotFound: true);
        m_Axis_Movement = m_Axis.FindAction("Movement", throwIfNotFound: true);
        m_Axis_Jump = m_Axis.FindAction("Jump", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Axis
    private readonly InputActionMap m_Axis;
    private IAxisActions m_AxisActionsCallbackInterface;
    private readonly InputAction m_Axis_MouseX;
    private readonly InputAction m_Axis_MouseY;
    private readonly InputAction m_Axis_Movement;
    private readonly InputAction m_Axis_Jump;
    public struct AxisActions
    {
        private @InputMaster m_Wrapper;
        public AxisActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @MouseX => m_Wrapper.m_Axis_MouseX;
        public InputAction @MouseY => m_Wrapper.m_Axis_MouseY;
        public InputAction @Movement => m_Wrapper.m_Axis_Movement;
        public InputAction @Jump => m_Wrapper.m_Axis_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Axis; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AxisActions set) { return set.Get(); }
        public void SetCallbacks(IAxisActions instance)
        {
            if (m_Wrapper.m_AxisActionsCallbackInterface != null)
            {
                @MouseX.started -= m_Wrapper.m_AxisActionsCallbackInterface.OnMouseX;
                @MouseX.performed -= m_Wrapper.m_AxisActionsCallbackInterface.OnMouseX;
                @MouseX.canceled -= m_Wrapper.m_AxisActionsCallbackInterface.OnMouseX;
                @MouseY.started -= m_Wrapper.m_AxisActionsCallbackInterface.OnMouseY;
                @MouseY.performed -= m_Wrapper.m_AxisActionsCallbackInterface.OnMouseY;
                @MouseY.canceled -= m_Wrapper.m_AxisActionsCallbackInterface.OnMouseY;
                @Movement.started -= m_Wrapper.m_AxisActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_AxisActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_AxisActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_AxisActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_AxisActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_AxisActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_AxisActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MouseX.started += instance.OnMouseX;
                @MouseX.performed += instance.OnMouseX;
                @MouseX.canceled += instance.OnMouseX;
                @MouseY.started += instance.OnMouseY;
                @MouseY.performed += instance.OnMouseY;
                @MouseY.canceled += instance.OnMouseY;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public AxisActions @Axis => new AxisActions(this);
    private int m_ControllerSchemeIndex = -1;
    public InputControlScheme ControllerScheme
    {
        get
        {
            if (m_ControllerSchemeIndex == -1) m_ControllerSchemeIndex = asset.FindControlSchemeIndex("Controller");
            return asset.controlSchemes[m_ControllerSchemeIndex];
        }
    }
    public interface IAxisActions
    {
        void OnMouseX(InputAction.CallbackContext context);
        void OnMouseY(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
