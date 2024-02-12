//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/Other/Controls.inputactions
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

public partial class @Controls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Rotation Controls"",
            ""id"": ""816ed0d8-3357-47a3-b90a-44c421cd755c"",
            ""actions"": [
                {
                    ""name"": ""StageRotate"",
                    ""type"": ""Value"",
                    ""id"": ""0d919aa8-7e0a-499f-a839-cda7dc730f81"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""b5e63e27-fcf3-4a6e-a35a-c90ded107853"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StageRotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ecc6ddb6-4daf-4ee6-8997-f642e5f9254b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""StageRotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b12978a9-24e4-45bd-a78a-ce961ceca449"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""StageRotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""5af36a52-a76b-44ef-b189-cee0859aed72"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StageRotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9ce80110-a8a9-4d24-b6d0-0c8cc0ef3f10"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""StageRotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8ec69b60-6db1-4767-9668-66a174436809"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""StageRotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Rotation Controls
        m_RotationControls = asset.FindActionMap("Rotation Controls", throwIfNotFound: true);
        m_RotationControls_StageRotate = m_RotationControls.FindAction("StageRotate", throwIfNotFound: true);
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

    // Rotation Controls
    private readonly InputActionMap m_RotationControls;
    private IRotationControlsActions m_RotationControlsActionsCallbackInterface;
    private readonly InputAction m_RotationControls_StageRotate;
    public struct RotationControlsActions
    {
        private @Controls m_Wrapper;
        public RotationControlsActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @StageRotate => m_Wrapper.m_RotationControls_StageRotate;
        public InputActionMap Get() { return m_Wrapper.m_RotationControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RotationControlsActions set) { return set.Get(); }
        public void SetCallbacks(IRotationControlsActions instance)
        {
            if (m_Wrapper.m_RotationControlsActionsCallbackInterface != null)
            {
                @StageRotate.started -= m_Wrapper.m_RotationControlsActionsCallbackInterface.OnStageRotate;
                @StageRotate.performed -= m_Wrapper.m_RotationControlsActionsCallbackInterface.OnStageRotate;
                @StageRotate.canceled -= m_Wrapper.m_RotationControlsActionsCallbackInterface.OnStageRotate;
            }
            m_Wrapper.m_RotationControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @StageRotate.started += instance.OnStageRotate;
                @StageRotate.performed += instance.OnStageRotate;
                @StageRotate.canceled += instance.OnStageRotate;
            }
        }
    }
    public RotationControlsActions @RotationControls => new RotationControlsActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IRotationControlsActions
    {
        void OnStageRotate(InputAction.CallbackContext context);
    }
}
