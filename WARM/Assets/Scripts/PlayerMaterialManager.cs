using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMaterialManager : MonoBehaviour
{
    private string BulletType;
    public int BasicOres;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        // if (other.CompareTag(BulletType))
        // {
        //     switch(BulletType) 
        //     {
        //         case "BasicOre":
        //         BasicOres += 5;
        //         break;
        //     }
        // }
    }
}
