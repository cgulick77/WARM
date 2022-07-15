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
                    ""path"": ""<Mouse>/delta"",
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
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShipShoot"",
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
    public struct PlayerShipActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerShipActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @ShipMovement => m_Wrapper.m_PlayerShip_ShipMovement;
        public InputAction @ShipAim => m_Wrapper.m_PlayerShip_ShipAim;
        public InputAction @ShipShoot => m_Wrapper.m_PlayerShip_ShipShoot;
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
            }
        }
    }
    public PlayerShipActions @PlayerShip => new PlayerShipActions(this);
    public interface IPlayerShipActions
    {
        void OnShipMovement(InputAction.CallbackContext context);
        void OnShipAim(InputAction.CallbackContext context);
        void OnShipShoot(InputAction.CallbackContext context);
    }
}
