using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OreDestroy : MonoBehaviour
{
    public GameObject oreMaterial;
    public float oreHealth;
    // Start is called before the first frame update
    void Start()
    {
        oreHealth = 100f;

    }

    // Update is called once per frame
    void Update()
    {
        if (oreHealth ==0)
        {
            Destroy(gameObject);
        }
    }
    
     void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag("BasicBullet"))
        {
            oreHealth -= 2;
            Debug.Log("Hit");
        }
     }

    void DropMaterials()
    {

    }
}
