using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMaterialManager : MonoBehaviour
{
    private string BulletType;
    public float totalBasicOres;
    private PlayerShoot playerShoot;
    
    public int firstBulletCount, firstOreRefine = 5;
    // Start is called before the first frame update
    void Start()
    {
        playerShoot = GetComponent<PlayerShoot>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
       
            switch(other.tag) 
            {
                case "BasicOre":
                totalBasicOres += 5;
                break;
            }
        
    }

    public void RefineOre(string OreType) 
    {
        switch (OreType)
        {
            case "FirstOre":
            float BasicOreConversion = 5f;
            if (totalBasicOres > 0)
            {
                totalBasicOres -= firstOreRefine;
            
            firstBulletCount = firstOreRefine * (int)BasicOreConversion;
            if (firstBulletCount > 0)
            {
                playerShoot.SetBulletTypes(false,true,false,false);
                
            }
           

            
            Debug.Log("Refined Ore");
            }


            break;
        }
    }
}
