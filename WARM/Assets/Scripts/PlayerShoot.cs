using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bullet, Ore1Bullet;
    private PlayerController playerController;
    private Inputs inputs;
    [SerializeField]
    private float rateOfFire;
    public GameObject bulletSpawn;
    public bool RegularB, FirstB, SecondB, ThirdB;

    
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
        //    if (RegularB == true)
        //    {
        //         //SetBulletTypes(true, false, false, false);
        //          StartCoroutine(ShootBasic(bullet));
        //    }

        //    if (FirstB == true)
        //    {    SetBulletTypes(false, true, false, false);
        //          StartCoroutine(ShootBasic(Ore1Bullet));
        //    }

           
           
        }
        
    }

  
    IEnumerator ShootBasic(GameObject bulletType)
    {
        yield return new WaitForSeconds(rateOfFire);
        Instantiate(bulletType, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
         
    }

    void SetBulletTypes(bool Regular, bool FirstType, bool SecondType, bool ThirdType)
    {
        RegularB = false;
        FirstB = false;
        SecondB = false;
        ThirdB = false;
    }

    
}
