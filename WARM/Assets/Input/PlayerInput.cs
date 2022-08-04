// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""PlayerShip"",
            ""id"": ""ee21953f-7bed-42e2-92ee-f2171a478ae5"",
            ""actions"": [
                {
                    ""name"": ""ShipMovement"",
                    ""type"": ""Button"",
                    ""id"": ""872161dc-ee77-4b10-ae04-c3c20046f796"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShipAim"",
                    ""type"": ""Value"",
                    ""id"": ""cf63d4bd-417d-461e-8eeb-82dae9bf0c8c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShipShoot"",
                    ""type"": ""Button"",
                    ""id"": ""922e31c7-309f-4fb2-8ddb-2733931290af"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""OpenShipUi"",
                    ""type"": ""Button"",
                    ""id"": ""07687914-b834-4de4-89f2-358d8ae935c1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UiOre1"",
                    ""type"": ""Button"",
                    ""id"": ""d7734e4f-6bda-4c5c-a39e-7d864f7b39e4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UiOre2"",
                    ""type"": ""Button"",
                    ""id"": ""3bde35ee-4ee2-467e-a980-4870b1f45f9f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UiOre3"",
                    ""type"": ""Button"",
                    ""id"": ""483704eb-2440-4815-ad2d-5c16baa9201c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""7d42d97a-966e-46c6-aaa8-6739978de0c5"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShipMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b4ebb657-7912-4d1e-9a6e-8fb8f43f8a6d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShipMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""318c02ea-5a3b-45ca-8dec-c96d3007de48"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShipMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""11b67b60-ff9b-458e-b8f8-d0f735dc9951"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShipMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d5090ce6-88a3-4d51-ac2b-6a440db0639e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShipMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4663a41d-cab4-4eb2-b7ae-8d4d21ce9beb"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShipAim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8681a7d-0a94-426e-a730-bf4445566ebf"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShipShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef229f63-7fe3-4fc5-8f4a-e693188555eb"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OpenShipUi"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3c58558c-29f1-463a-9332-81a39ce57b96"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UiOre1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2560cd7e-3504-41d9-9852-99a877723623"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UiOre2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cfad53c8-8aad-43b2-82c6-c061be6e0073"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UiOre3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerShip
        m_PlayerShip = asset.FindActionMap("PlayerShip", throwIfNotFound: true);
        m_PlayerShip_ShipMovement = m_PlayerShip.FindAction("ShipMovement", throwIfNotFound: true);
        m_PlayerShip_ShipAim = m_PlayerShip.FindAction("ShipAim", throwIfNotFound: true);
        m_PlayerShip_ShipShoot = m_PlayerShip.FindAction("ShipShoot", throwIfNotFound: true);
        m_PlayerShip_OpenShipUi = m_PlayerShip.FindAction("OpenShipUi", throwIfNotFound: true);
        m_PlayerShip_UiOre1 = m_PlayerShip.FindAction("UiOre1", throwIfNotFound: true);
        m_PlayerShip_UiOre2 = m_PlayerShip.FindAction("UiOre2", throwIfNotFound: true);
        m_PlayerShip_UiOre3 = m_PlayerShip.FindAction("UiOre3", throwIfNotFound: true);
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

    // PlayerShip
    private readonly InputActionMap m_PlayerShip;
    private IPlayerShipActions m_PlayerShipActionsCallbackInterface;
    private readonly InputAction m_PlayerShip_ShipMovement;
    private readonly InputAction m_PlayerShip_ShipAim;
    private readonly InputAction m_PlayerShip_ShipShoot;
    private readonly InputAction m_PlayerShip_OpenShipUi;
    private readonly InputAction m_PlayerShip_UiOre1;
    private readonly InputAction m_PlayerShip_UiOre2;
    private readonly InputAction m_PlayerShip_UiOre3;
    public struct PlayerShipActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerShipActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @ShipMovement => m_Wrapper.m_PlayerShip_ShipMovement;
        public InputAction @ShipAim => m_Wrapper.m_PlayerShip_ShipAim;
        public InputAction @ShipShoot => m_Wrapper.m_PlayerShip_ShipShoot;
        public InputAction @OpenShipUi => m_Wrapper.m_PlayerShip_OpenShipUi;
        public InputAction @UiOre1 => m_Wrapper.m_PlayerShip_UiOre1;
        public InputAction @UiOre2 => m_Wrapper.m_PlayerShip_UiOre2;
        public InputAction @UiOre3 => m_Wrapper.m_PlayerShip_UiOre3;
        public InputActionMap Get() { return m_Wrapper.m_PlayerShip; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerShipActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerShipActions instance)
        {
            if (m_Wrapper.m_PlayerShipActionsCallbackInterface != null)
            {
                @ShipMovement.started -= m_Wrapper.m_PlayerShipActionsCallbackInterface.OnShipMovement;
                @ShipMovement.performed -= m_Wrapper.m_PlayerShipActionsCallbackInterface.OnShipMovement;
                @ShipMovement.canceled -= m_Wrapper.m_PlayerShipActionsCallbackInterface.OnShipMovement;
                @ShipAim.started -= m_Wrapper.m_PlayerShipActionsCallbackInterface.OnShipAim;
                @ShipAim.performed -= m_Wrapper.m_PlayerShipActionsCallbackInterface.OnShipAim;
                @ShipAim.canceled -= m_Wrapper.m_PlayerShipActionsCallbackInterface.OnShipAim;
                @ShipShoot.started -= m_Wrapper.m_PlayerShipActionsCallbackInterface.OnShipShoot;
                @ShipShoot.performed -= m_Wrapper.m_PlayerShipActionsCallbackInterface.OnShipShoot;
                @ShipShoot.canceled -= m_Wrapper.m_PlayerShipActionsCallbackInterface.OnShipShoot;
                @OpenShipUi.started -= m_Wrapper.m_PlayerShipActionsCallbackInterface.OnOpenShipUi;
                @OpenShipUi.performed -= m_Wrapper.m_PlayerShipActionsCallbackInterface.OnOpenShipUi;
                @OpenShipUi.canceled -= m_Wrapper.m_PlayerShipActionsCallbackInterface.OnOpenShipUi;
                @UiOre1.started -= m_Wrapper.m_PlayerShipActionsCallbackInterface.OnUiOre1;
                @UiOre1.performed -= m_Wrapper.m_PlayerShipActionsCallbackInterface.OnUiOre1;
                @UiOre1.canceled -= m_Wrapper.m_PlayerShipActionsCallbackInterface.OnUiOre1;
                @UiOre2.started -= m_Wrapper.m_PlayerShipActionsCallbackInterface.OnUiOre2;
                @UiOre2.performed -= m_Wrapper.m_PlayerShipActionsCallbackInterface.OnUiOre2;
                @UiOre2.canceled -= m_Wrapper.m_PlayerShipActionsCallbackInterface.OnUiOre2;
                @UiOre3.started -= m_Wrapper.m_PlayerShipActionsCallbackInterface.OnUiOre3;
                @UiOre3.performed -= m_Wrapper.m_PlayerShipActionsCallbackInterface.OnUiOre3;
                @UiOre3.canceled -= m_Wrapper.m_PlayerShipActionsCallbackInterface.OnUiOre3;
            }
            m_Wrapper.m_PlayerShipActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ShipMovement.started += instance.OnShipMovement;
                @ShipMovement.performed += instance.OnShipMovement;
                @ShipMovement.canceled += instance.OnShipMovement;
                @ShipAim.started += instance.OnShipAim;
                @ShipAim.performed += instance.OnShipAim;
                @ShipAim.canceled += instance.OnShipAim;
                @ShipShoot.started += instance.OnShipShoot;
                @ShipShoot.performed += instance.OnShipShoot;
                @ShipShoot.canceled += instance.OnShipShoot;
                @OpenShipUi.started += instance.OnOpenShipUi;
                @OpenShipUi.performed += instance.OnOpenShipUi;
                @OpenShipUi.canceled += instance.OnOpenShipUi;
                @UiOre1.started += instance.OnUiOre1;
                @UiOre1.performed += instance.OnUiOre1;
                @UiOre1.canceled += instance.OnUiOre1;
                @UiOre2.started += instance.OnUiOre2;
                @UiOre2.performed += instance.OnUiOre2;
                @UiOre2.canceled += instance.OnUiOre2;
                @UiOre3.started += instance.OnUiOre3;
                @UiOre3.performed += instance.OnUiOre3;
                @UiOre3.canceled += instance.OnUiOre3;
            }
        }
    }
    public PlayerShipActions @PlayerShip => new PlayerShipActions(this);
    public interface IPlayerShipActions
    {
        void OnShipMovement(InputAction.CallbackContext context);
        void OnShipAim(InputAction.CallbackContext context);
        void OnShipShoot(InputAction.CallbackContext context);
        void OnOpenShipUi(InputAction.CallbackContext context);
        void OnUiOre1(InputAction.CallbackContext context);
        void OnUiOre2(InputAction.CallbackContext context);
        void OnUiOre3(InputAction.CallbackContext context);
    }
}
