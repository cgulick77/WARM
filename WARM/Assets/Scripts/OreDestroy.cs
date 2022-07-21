using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OreDestroy : MonoBehaviour
{
    public GameObject oreMaterial;
    public float oreHealth;
    public int oreAmmount = 5, x;
    private Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        oreHealth = 50f;

    }

    // Update is called once per frame
    void Update()
    {
        if (oreHealth == 0)
        {
            
            Destroy(gameObject);
        }
        else if (oreHealth <= 10)
        {
            //DropMaterials();
        }
    }
    
     void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag("BasicBullet"))
        {
            oreHealth -= 10;
            Debug.Log("Hit");
        }
     }

    void DropMaterials()
    {
       direction = Random.insideUnitCircle.normalized; // Random Direction

        while (x != oreAmmount)
        {
            Instantiate(oreMaterial, direction, transform.rotation);
            x++;
        }
        
    }
}
