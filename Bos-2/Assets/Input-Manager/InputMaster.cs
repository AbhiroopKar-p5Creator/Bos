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
                    ""name"": ""Horizontal"",
                    ""type"": ""Button"",
                    ""id"": ""b63ef5df-2f86-41e0-9ce1-308cabde23bb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Vertical"",
                    ""type"": ""Button"",
                    ""id"": ""48b3bf3f-8271-4192-91ae-68b84e85192e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Bindings"",
                    ""id"": ""941db278-89d8-41ba-98ff-e381a5d2d17c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c6c0dcc5-a30a-4c81-a270-2cf2890d316e"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""8a4d4189-56c2-427b-83d9-c2d5c7d10763"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""de89cb14-f3b0-4ebb-8005-1aeb39822462"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6300523c-afc8-41e7-ab2b-42e780a9445a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Bindings"",
                    ""id"": ""f516a1e0-d9aa-4ff9-ab0f-0150813ce8ad"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""bf364924-e2c3-4147-b96e-7e458b43ee8e"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a179442c-339f-4b3c-a3f6-54870ce147c1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1a8009cd-a37e-4a0a-87fe-305c6968ffec"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7b7e7099-c377-430e-8824-d3509bdccf62"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
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
        m_Axis_Horizontal = m_Axis.FindAction("Horizontal", throwIfNotFound: true);
        m_Axis_Vertical = m_Axis.FindAction("Vertical", throwIfNotFound: true);
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
    private readonly InputAction m_Axis_Horizontal;
    private readonly InputAction m_Axis_Vertical;
    public struct AxisActions
    {
        private @InputMaster m_Wrapper;
        public AxisActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Horizontal => m_Wrapper.m_Axis_Horizontal;
        public InputAction @Vertical => m_Wrapper.m_Axis_Vertical;
        public InputActionMap Get() { return m_Wrapper.m_Axis; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AxisActions set) { return set.Get(); }
        public void SetCallbacks(IAxisActions instance)
        {
            if (m_Wrapper.m_AxisActionsCallbackInterface != null)
            {
                @Horizontal.started -= m_Wrapper.m_AxisActionsCallbackInterface.OnHorizontal;
                @Horizontal.performed -= m_Wrapper.m_AxisActionsCallbackInterface.OnHorizontal;
                @Horizontal.canceled -= m_Wrapper.m_AxisActionsCallbackInterface.OnHorizontal;
                @Vertical.started -= m_Wrapper.m_AxisActionsCallbackInterface.OnVertical;
                @Vertical.performed -= m_Wrapper.m_AxisActionsCallbackInterface.OnVertical;
                @Vertical.canceled -= m_Wrapper.m_AxisActionsCallbackInterface.OnVertical;
            }
            m_Wrapper.m_AxisActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Horizontal.started += instance.OnHorizontal;
                @Horizontal.performed += instance.OnHorizontal;
                @Horizontal.canceled += instance.OnHorizontal;
                @Vertical.started += instance.OnVertical;
                @Vertical.performed += instance.OnVertical;
                @Vertical.canceled += instance.OnVertical;
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
        void OnHorizontal(InputAction.CallbackContext context);
        void OnVertical(InputAction.CallbackContext context);
    }
}
