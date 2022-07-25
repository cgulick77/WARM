using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMaterialManager : MonoBehaviour
{
    private string BulletType;
    public int BasicOres;
    public int BasicOreBullet;
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
                BasicOres += 5;
                break;
            }
        
    }
}
