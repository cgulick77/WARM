using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed;
    public float bulletDestroyTime;
    private Rigidbody2D bulletRb;
    // Start is called before the first frame update
    void Start()
    {
        bulletRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       bulletRb.velocity = new Vector2(0.0f, bulletSpeed);
       StartCoroutine("bulletDestroy");
    }

    IEnumerator bulletDestroy()
    {
        yield return new WaitForSeconds(bulletDestroyTime);
        Destroy(gameObject);
        StopAllCoroutines();
    }

    
}
