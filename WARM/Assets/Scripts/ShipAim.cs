using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipAim : MonoBehaviour
{
    
    //public GameObject shipOuter;
    private Transform aimTransform;

    public void ShipLook(Vector2 input)
    {
        Vector3 mousePosition =  Vector3.zero;
        mousePosition.x = input.x;
        mousePosition.y = input.y;

        Vector3 aimDirection = (mousePosition - transform.position).normalized;
        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x )* Mathf.Rad2Deg;
        aimTransform.eulerAngles = new Vector3(0,0,angle);

        
    }
    
   
}
