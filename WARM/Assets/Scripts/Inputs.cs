using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Inputs : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerInput.PlayerShipActions shipActions;
    private PlayerController playerController;
    private ShipAim shipAim;
     void Awake() 
    {
        playerInput = new PlayerInput();
        shipActions = playerInput.PlayerShip;
        playerController = GetComponent<PlayerController>();
        shipAim = GetComponent<ShipAim>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        playerController.MoveShip(shipActions.ShipMovement.ReadValue<Vector2>());
        
        
    }
    void LateUpdate() 
    {
        shipAim.ShipLook(shipActions.ShipAim.ReadValue<Vector2>());
    }
    private void OnEnable() 
    {
        
        shipActions.Enable();
    }

    private void OnDisable() 
    {
        shipActions.Disable();
    }
}
