//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/Scripts/Input/Controls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Controls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""KeyboardAndMouse"",
            ""id"": ""245a1cd9-cb40-44f8-a900-56ae5868003c"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""63356496-fe9e-4c62-94fe-58bcd2b88cd8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""RotateMouse"",
                    ""type"": ""Value"",
                    ""id"": ""4fa981e3-4476-4ead-9818-795cf52bed08"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""GetRotateCamera"",
                    ""type"": ""Button"",
                    ""id"": ""08cd78f9-b4dd-4ab1-8ff2-7b5de7b5126c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SimpleAttack"",
                    ""type"": ""Button"",
                    ""id"": ""d327767d-0044-493b-831b-6d588db1e89f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""ba201887-0143-4f3a-87bf-532134cef2f2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9e34fee9-48a3-4b4e-accb-4a8e1a6f2bb2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""24825456-a2fe-42c8-b4d7-7c2e3d99840b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6ad8d297-a19b-44fb-aeee-72f26b0edb3c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""506c10a1-f0ea-42b9-97e0-ea4e5a4bed36"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9cb9826a-3a65-4980-9454-6d13f3a84d46"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateMouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f1f02003-36b1-4ca7-af29-94177b35d661"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GetRotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a6c6da12-052a-4518-aa12-eed07082aca5"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SimpleAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // KeyboardAndMouse
        m_KeyboardAndMouse = asset.FindActionMap("KeyboardAndMouse", throwIfNotFound: true);
        m_KeyboardAndMouse_Move = m_KeyboardAndMouse.FindAction("Move", throwIfNotFound: true);
        m_KeyboardAndMouse_RotateMouse = m_KeyboardAndMouse.FindAction("RotateMouse", throwIfNotFound: true);
        m_KeyboardAndMouse_GetRotateCamera = m_KeyboardAndMouse.FindAction("GetRotateCamera", throwIfNotFound: true);
        m_KeyboardAndMouse_SimpleAttack = m_KeyboardAndMouse.FindAction("SimpleAttack", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // KeyboardAndMouse
    private readonly InputActionMap m_KeyboardAndMouse;
    private List<IKeyboardAndMouseActions> m_KeyboardAndMouseActionsCallbackInterfaces = new List<IKeyboardAndMouseActions>();
    private readonly InputAction m_KeyboardAndMouse_Move;
    private readonly InputAction m_KeyboardAndMouse_RotateMouse;
    private readonly InputAction m_KeyboardAndMouse_GetRotateCamera;
    private readonly InputAction m_KeyboardAndMouse_SimpleAttack;
    public struct KeyboardAndMouseActions
    {
        private @Controls m_Wrapper;
        public KeyboardAndMouseActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_KeyboardAndMouse_Move;
        public InputAction @RotateMouse => m_Wrapper.m_KeyboardAndMouse_RotateMouse;
        public InputAction @GetRotateCamera => m_Wrapper.m_KeyboardAndMouse_GetRotateCamera;
        public InputAction @SimpleAttack => m_Wrapper.m_KeyboardAndMouse_SimpleAttack;
        public InputActionMap Get() { return m_Wrapper.m_KeyboardAndMouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyboardAndMouseActions set) { return set.Get(); }
        public void AddCallbacks(IKeyboardAndMouseActions instance)
        {
            if (instance == null || m_Wrapper.m_KeyboardAndMouseActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_KeyboardAndMouseActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @RotateMouse.started += instance.OnRotateMouse;
            @RotateMouse.performed += instance.OnRotateMouse;
            @RotateMouse.canceled += instance.OnRotateMouse;
            @GetRotateCamera.started += instance.OnGetRotateCamera;
            @GetRotateCamera.performed += instance.OnGetRotateCamera;
            @GetRotateCamera.canceled += instance.OnGetRotateCamera;
            @SimpleAttack.started += instance.OnSimpleAttack;
            @SimpleAttack.performed += instance.OnSimpleAttack;
            @SimpleAttack.canceled += instance.OnSimpleAttack;
        }

        private void UnregisterCallbacks(IKeyboardAndMouseActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @RotateMouse.started -= instance.OnRotateMouse;
            @RotateMouse.performed -= instance.OnRotateMouse;
            @RotateMouse.canceled -= instance.OnRotateMouse;
            @GetRotateCamera.started -= instance.OnGetRotateCamera;
            @GetRotateCamera.performed -= instance.OnGetRotateCamera;
            @GetRotateCamera.canceled -= instance.OnGetRotateCamera;
            @SimpleAttack.started -= instance.OnSimpleAttack;
            @SimpleAttack.performed -= instance.OnSimpleAttack;
            @SimpleAttack.canceled -= instance.OnSimpleAttack;
        }

        public void RemoveCallbacks(IKeyboardAndMouseActions instance)
        {
            if (m_Wrapper.m_KeyboardAndMouseActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IKeyboardAndMouseActions instance)
        {
            foreach (var item in m_Wrapper.m_KeyboardAndMouseActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_KeyboardAndMouseActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public KeyboardAndMouseActions @KeyboardAndMouse => new KeyboardAndMouseActions(this);
    public interface IKeyboardAndMouseActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRotateMouse(InputAction.CallbackContext context);
        void OnGetRotateCamera(InputAction.CallbackContext context);
        void OnSimpleAttack(InputAction.CallbackContext context);
    }
}
