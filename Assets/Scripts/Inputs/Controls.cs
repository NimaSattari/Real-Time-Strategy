// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""46d68cb9-f6c5-40d2-a116-a625d09ed01a"",
            ""actions"": [
                {
                    ""name"": ""Move Camera"",
                    ""type"": ""Value"",
                    ""id"": ""0163fc1e-aa18-43c4-b865-f9227a25f072"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reset Camera"",
                    ""type"": ""Button"",
                    ""id"": ""6c357fdc-9d61-4927-94b2-d5d7ad87e1bf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Zoom Camera"",
                    ""type"": ""Value"",
                    ""id"": ""0473577a-2e2d-4988-b388-16b890d9f1cb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select All Units"",
                    ""type"": ""Button"",
                    ""id"": ""a2336033-c3a2-478a-95b9-0dd5c57cedda"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""6ec6615d-21ea-4a91-aa46-6a07b004159a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""e229dfc8-bd8e-4039-afd0-35d835e69ca3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Camera"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""289a8557-c4e4-45e9-8673-c1aaa844b498"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Move Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""bbc7779d-7518-456c-8cda-d9bb3635af22"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Move Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cbb9b2b5-5d83-409a-94a9-b115e60c28c2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Move Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e7999bea-874c-4789-bdf4-5a521e57d9b6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Move Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrow Keys"",
                    ""id"": ""e662aa0e-d438-433e-b0e6-5f801c051ba3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Camera"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""dde971d8-398a-4770-be7b-6e5035e41003"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Move Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""eabfd05c-9560-47e8-99e7-a0a0e78c691d"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Move Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a8bacd2d-8f2b-4d40-b3da-0020a746aedc"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Move Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7696e9b3-ce05-4d2a-89ce-9f2581e8795f"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Move Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""35abf849-33d8-4f1a-9c12-19077296cd00"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Move Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0276d56a-c2e4-4356-8b9d-02ffb5d1ea8e"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Reset Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4166474b-03bc-4989-a4e8-f0ef6edc7331"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Zoom Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5a63300a-f77f-43b9-bdf9-9eef13b4a917"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Select All Units"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8cb8849-d78b-46a9-b4fe-4212dd1bcc5e"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard & Mouse"",
            ""bindingGroup"": ""Keyboard & Mouse"",
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
        },
        {
            ""name"": ""GamePad"",
            ""bindingGroup"": ""GamePad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_MoveCamera = m_Player.FindAction("Move Camera", throwIfNotFound: true);
        m_Player_ResetCamera = m_Player.FindAction("Reset Camera", throwIfNotFound: true);
        m_Player_ZoomCamera = m_Player.FindAction("Zoom Camera", throwIfNotFound: true);
        m_Player_SelectAllUnits = m_Player.FindAction("Select All Units", throwIfNotFound: true);
        m_Player_Pause = m_Player.FindAction("Pause", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_MoveCamera;
    private readonly InputAction m_Player_ResetCamera;
    private readonly InputAction m_Player_ZoomCamera;
    private readonly InputAction m_Player_SelectAllUnits;
    private readonly InputAction m_Player_Pause;
    public struct PlayerActions
    {
        private @Controls m_Wrapper;
        public PlayerActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveCamera => m_Wrapper.m_Player_MoveCamera;
        public InputAction @ResetCamera => m_Wrapper.m_Player_ResetCamera;
        public InputAction @ZoomCamera => m_Wrapper.m_Player_ZoomCamera;
        public InputAction @SelectAllUnits => m_Wrapper.m_Player_SelectAllUnits;
        public InputAction @Pause => m_Wrapper.m_Player_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @MoveCamera.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveCamera;
                @MoveCamera.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveCamera;
                @MoveCamera.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveCamera;
                @ResetCamera.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnResetCamera;
                @ResetCamera.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnResetCamera;
                @ResetCamera.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnResetCamera;
                @ZoomCamera.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnZoomCamera;
                @ZoomCamera.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnZoomCamera;
                @ZoomCamera.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnZoomCamera;
                @SelectAllUnits.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelectAllUnits;
                @SelectAllUnits.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelectAllUnits;
                @SelectAllUnits.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelectAllUnits;
                @Pause.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveCamera.started += instance.OnMoveCamera;
                @MoveCamera.performed += instance.OnMoveCamera;
                @MoveCamera.canceled += instance.OnMoveCamera;
                @ResetCamera.started += instance.OnResetCamera;
                @ResetCamera.performed += instance.OnResetCamera;
                @ResetCamera.canceled += instance.OnResetCamera;
                @ZoomCamera.started += instance.OnZoomCamera;
                @ZoomCamera.performed += instance.OnZoomCamera;
                @ZoomCamera.canceled += instance.OnZoomCamera;
                @SelectAllUnits.started += instance.OnSelectAllUnits;
                @SelectAllUnits.performed += instance.OnSelectAllUnits;
                @SelectAllUnits.canceled += instance.OnSelectAllUnits;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard & Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamePadSchemeIndex = -1;
    public InputControlScheme GamePadScheme
    {
        get
        {
            if (m_GamePadSchemeIndex == -1) m_GamePadSchemeIndex = asset.FindControlSchemeIndex("GamePad");
            return asset.controlSchemes[m_GamePadSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMoveCamera(InputAction.CallbackContext context);
        void OnResetCamera(InputAction.CallbackContext context);
        void OnZoomCamera(InputAction.CallbackContext context);
        void OnSelectAllUnits(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
