using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialThrower : MonoBehaviour
{
    public Rigidbody materialRb;
    private Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(ThrowMaterial());
    }
    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator ThrowMaterial()
    {
        direction = Random.insideUnitCircle.normalized;
        materialRb.AddForce(direction* 10f);
        yield return new WaitForSeconds(.01f);
        materialRb.velocity =  Vector3.zero;
        StopAllCoroutines();
    }

   
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Bruhg");
            Destroy(gameObject);
        }
    }
    

}

    
        
