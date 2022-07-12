using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    
    private CharacterController playerController;
    private Vector3 playerVelocity;
    public float playerSpeed;
    public GameObject shipOuter;

    void Start() 
    {
        playerController = GetComponent<CharacterController>();
    }


    // Update is called once per frame
    void Update()
    {
      
    }

    public void MoveShip(Vector2 input)
    {
        Vector3 moveDirection =Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.y = input.y;

        playerController.Move(transform.TransformDirection(moveDirection * playerSpeed * Time.deltaTime));
    }

   
}