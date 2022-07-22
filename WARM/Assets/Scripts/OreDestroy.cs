using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OreDestroy : MonoBehaviour
{
    public GameObject oreMaterial;
    public float oreHealth, startingHealth;
    public int oreAmmount = 5, x;
    private Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        oreHealth = startingHealth;

    }

    // Update is called once per frame
    void Update()
    {
        if (oreHealth == 0)
        {
            DropMaterials();
            Destroy(gameObject);
        }
        
      
           
       
    }
    
     void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag("BasicBullet"))
        {
            oreHealth -= 10;
            //Debug.Log("Hit");
        }
     }

    void DropMaterials()
    {
       //direction = Random.insideUnitCircle.normalized; // Random Direction
        StartCoroutine(SpawnMats());

    }

    IEnumerator SpawnMats()
    {
        Instantiate(oreMaterial, transform.position, transform.rotation);
        yield return new WaitForSeconds(.1f);
        StopCoroutine(SpawnMats());
    }
}
