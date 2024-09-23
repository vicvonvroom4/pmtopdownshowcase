using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletpath : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;
    float bulletSpeed = 10f;
    [SerializeField]
    float bulletLifetime = 2.0f;
    float shootDelay = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shootDelay += Time.deltaTime;
        if (Input.GetButton("Fire1") && shootDelay > 0.5f) 
        {
            shootDelay = 0;
            Vector3 mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            Debug.Log(mousePos);
            mousePos.z = 0;
            Vector3 mouseDir = mousePos - transform.position;
            mouseDir.Normalize();
            GameObject Bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            Bullet.GetComponent<Rigidbody2D>().velocity = mouseDir * bulletSpeed;
            Destroy(Bullet, bulletLifetime);
        }  
    }
}
