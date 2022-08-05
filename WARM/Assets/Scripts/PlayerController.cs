using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    
    private CharacterController playerController;
    private Vector2 playerVelocity;
    public float playerSpeed;
    public GameObject shipOuter;

    public float generalSpeed;
    private Rigidbody2D playerRb;
    //[SerializeField] Camera camera;

    void Start() 
    {
        playerController = GetComponent<CharacterController>();
        playerRb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        
      //playerController.Move(Vector3.down * generalSpeed * Time.deltaTime);
    }

    public void MoveShip(Vector2 input)
    {
        Vector2 moveDirection =Vector2.zero;
        moveDirection.x = input.x;
        moveDirection.y = input.y;

        playerRb.velocity = moveDirection * playerSpeed;

        // mousePos = camera.ScreenToWorldPoint(mousePos);

        // Vector2 facingDirection = mousePos - playerRb.position;

        // float angle = Mathf.Atan2(facingDirection.y, facingDirection.x) * Mathf.Rad2Deg;
        // playerRb.MoveRotation(angle);
        //playerController.Move(transform.TransformDirection(moveDirection * playerSpeed * Time.deltaTime));
    }

    public void AimShip(Vector2 mousePos)
    {
         //mousePos = camera.ScreenToWorldPoint(mousePos);

       Vector2 facingDirection = mousePos - playerRb.position;

        float angle = Mathf.Atan2(facingDirection.y, facingDirection.x) * Mathf.Rad2Deg;
        playerRb.MoveRotation(angle);
        //playerController.Move(transform.TransformDirection(moveDirection * playerSpeed * Time.deltaTime));
    }

   
}
