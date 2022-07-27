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
    private PlayerMaterialManager playerMaterialManager;

    
    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent<PlayerController>();
        inputs = GetComponent<Inputs>();
        playerMaterialManager = GetComponent<PlayerMaterialManager>();
        SetBulletTypes(true,false,false,false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inputs.shipActions.ShipShoot.triggered)
        {
           if (RegularB == true)
           {
                //SetBulletTypes(true, false, false, false);
                 StartCoroutine(ShootBasic(bullet));
           }

           if (FirstB == true)
           {    //SetBulletTypes(false, true, false, false);
                if (playerMaterialManager.firstBulletCount > 0)
                {
                    StartCoroutine(ShootBasic(Ore1Bullet));
                    playerMaterialManager.firstBulletCount -= 5;
                } 
                else 
                {
                    SetBulletTypes(true,false,false,false);
                }   
           }

        }
        
    }

  
    IEnumerator ShootBasic(GameObject bulletType)
    {
        yield return new WaitForSeconds(rateOfFire);
        Instantiate(bulletType, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
         
    }

    public void SetBulletTypes(bool Regular, bool FirstType, bool SecondType, bool ThirdType)
    {
        RegularB = Regular;
        FirstB = FirstType;
        SecondB = SecondType;
        ThirdB = ThirdType;
    }

    
}
