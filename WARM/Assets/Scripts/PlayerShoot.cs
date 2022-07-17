using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bullet;
    private PlayerController playerController;
    private Inputs inputs;
    [SerializeField]
    private float rateOfFire;

    
    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent<PlayerController>();
        inputs = GetComponent<Inputs>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inputs.shipActions.ShipShoot.triggered)
        {
            //Debug.Log("SHOT");
            StartCoroutine("ShootBasic");
        }
    }

   
        
        
    

    IEnumerator ShootBasic()
    {
        yield return new WaitForSeconds(rateOfFire);
        Instantiate(bullet, transform.position, transform.rotation);
         
    }
}
