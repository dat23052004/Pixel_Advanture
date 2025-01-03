//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/NewInputSystem/NewInputAction.inputactions
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

public partial class @NewInputAction: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @NewInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""NewInputAction"",
    ""maps"": [
        {
            ""name"": ""BasicActionMap"",
            ""id"": ""fa1b6f2f-179f-4cf7-9ac7-7f48e4e588db"",
            ""actions"": [
                {
                    ""name"": ""LeftAnalog"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0381a187-2a7e-4c29-bb1f-9040916815b3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""e7b40a4b-2783-4978-b65d-ef3eb19e9eca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""be9f98a5-ae81-4466-b29d-f9323adea58b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Enter"",
                    ""type"": ""Button"",
                    ""id"": ""29499814-041a-4e40-9760-6f2e6f6da8c8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Select Up"",
                    ""type"": ""Button"",
                    ""id"": ""dd9cf7c9-34ce-4068-aa2f-a6741b4ebc7b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Select Down"",
                    ""type"": ""Button"",
                    ""id"": ""3c80e7c0-c57f-4505-abbd-6e400cc915d5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6e0d780d-4826-4ce1-a2d0-55839950abb0"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftAnalog"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Dpad"",
                    ""id"": ""819573db-a9fb-4219-912f-4025552b9cc1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftAnalog"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9a8be7fa-3eba-44c5-913a-57632dcf033b"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftAnalog"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""00bc67ae-ff49-4374-a9e1-355262f90490"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftAnalog"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""06572438-1968-48f2-ac04-ad3b8831cff3"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftAnalog"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""def0f53c-c530-4932-8f9e-c61bc0be438a"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftAnalog"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0ee4d617-c58f-48af-a197-924ce61fd8eb"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9b0fb951-497a-4618-aac3-cd8cfcdea766"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""36b91a14-3e09-4f78-8eb8-ca550a5587c1"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Enter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""373cb25d-82d9-41ac-9b62-44e299595a53"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""408f6ce5-28dd-4d7a-a372-addd2a8f6d98"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // BasicActionMap
        m_BasicActionMap = asset.FindActionMap("BasicActionMap", throwIfNotFound: true);
        m_BasicActionMap_LeftAnalog = m_BasicActionMap.FindAction("LeftAnalog", throwIfNotFound: true);
        m_BasicActionMap_Jump = m_BasicActionMap.FindAction("Jump", throwIfNotFound: true);
        m_BasicActionMap_Run = m_BasicActionMap.FindAction("Run", throwIfNotFound: true);
        m_BasicActionMap_Enter = m_BasicActionMap.FindAction("Enter", throwIfNotFound: true);
        m_BasicActionMap_SelectUp = m_BasicActionMap.FindAction("Select Up", throwIfNotFound: true);
        m_BasicActionMap_SelectDown = m_BasicActionMap.FindAction("Select Down", throwIfNotFound: true);
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

    // BasicActionMap
    private readonly InputActionMap m_BasicActionMap;
    private List<IBasicActionMapActions> m_BasicActionMapActionsCallbackInterfaces = new List<IBasicActionMapActions>();
    private readonly InputAction m_BasicActionMap_LeftAnalog;
    private readonly InputAction m_BasicActionMap_Jump;
    private readonly InputAction m_BasicActionMap_Run;
    private readonly InputAction m_BasicActionMap_Enter;
    private readonly InputAction m_BasicActionMap_SelectUp;
    private readonly InputAction m_BasicActionMap_SelectDown;
    public struct BasicActionMapActions
    {
        private @NewInputAction m_Wrapper;
        public BasicActionMapActions(@NewInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftAnalog => m_Wrapper.m_BasicActionMap_LeftAnalog;
        public InputAction @Jump => m_Wrapper.m_BasicActionMap_Jump;
        public InputAction @Run => m_Wrapper.m_BasicActionMap_Run;
        public InputAction @Enter => m_Wrapper.m_BasicActionMap_Enter;
        public InputAction @SelectUp => m_Wrapper.m_BasicActionMap_SelectUp;
        public InputAction @SelectDown => m_Wrapper.m_BasicActionMap_SelectDown;
        public InputActionMap Get() { return m_Wrapper.m_BasicActionMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BasicActionMapActions set) { return set.Get(); }
        public void AddCallbacks(IBasicActionMapActions instance)
        {
            if (instance == null || m_Wrapper.m_BasicActionMapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_BasicActionMapActionsCallbackInterfaces.Add(instance);
            @LeftAnalog.started += instance.OnLeftAnalog;
            @LeftAnalog.performed += instance.OnLeftAnalog;
            @LeftAnalog.canceled += instance.OnLeftAnalog;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Run.started += instance.OnRun;
            @Run.performed += instance.OnRun;
            @Run.canceled += instance.OnRun;
            @Enter.started += instance.OnEnter;
            @Enter.performed += instance.OnEnter;
            @Enter.canceled += instance.OnEnter;
            @SelectUp.started += instance.OnSelectUp;
            @SelectUp.performed += instance.OnSelectUp;
            @SelectUp.canceled += instance.OnSelectUp;
            @SelectDown.started += instance.OnSelectDown;
            @SelectDown.performed += instance.OnSelectDown;
            @SelectDown.canceled += instance.OnSelectDown;
        }

        private void UnregisterCallbacks(IBasicActionMapActions instance)
        {
            @LeftAnalog.started -= instance.OnLeftAnalog;
            @LeftAnalog.performed -= instance.OnLeftAnalog;
            @LeftAnalog.canceled -= instance.OnLeftAnalog;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Run.started -= instance.OnRun;
            @Run.performed -= instance.OnRun;
            @Run.canceled -= instance.OnRun;
            @Enter.started -= instance.OnEnter;
            @Enter.performed -= instance.OnEnter;
            @Enter.canceled -= instance.OnEnter;
            @SelectUp.started -= instance.OnSelectUp;
            @SelectUp.performed -= instance.OnSelectUp;
            @SelectUp.canceled -= instance.OnSelectUp;
            @SelectDown.started -= instance.OnSelectDown;
            @SelectDown.performed -= instance.OnSelectDown;
            @SelectDown.canceled -= instance.OnSelectDown;
        }

        public void RemoveCallbacks(IBasicActionMapActions instance)
        {
            if (m_Wrapper.m_BasicActionMapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IBasicActionMapActions instance)
        {
            foreach (var item in m_Wrapper.m_BasicActionMapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_BasicActionMapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public BasicActionMapActions @BasicActionMap => new BasicActionMapActions(this);
    public interface IBasicActionMapActions
    {
        void OnLeftAnalog(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnEnter(InputAction.CallbackContext context);
        void OnSelectUp(InputAction.CallbackContext context);
        void OnSelectDown(InputAction.CallbackContext context);
    }
}
