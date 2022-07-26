using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMaterialManager : MonoBehaviour
{
    private string BulletType;
    public float totalBasicOres;
    
    public int firstBulletCount, firstOreRefine = 5;
    // Start is called before the first frame update
    void Start()
    {
        
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
            totalBasicOres -= firstOreRefine;
            
            firstBulletCount = firstOreRefine * (int)BasicOreConversion;
            
            Debug.Log("Refined Ore");

            break;
        }
    }
}
