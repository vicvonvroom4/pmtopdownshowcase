using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyai : MonoBehaviour
{
    GameObject player;
    [SerializeField]
    float chaseTriggerDistance = 10f;
    [SerializeField]
    float chasespeed = 5.0f;
    [SerializeField]
    bool GoHome = true;
    Vector3 homePosition;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        homePosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = player.transform.position;
        Vector3 chaseDir = playerPosition - transform.position;
        Vector3 HomeDir = homePosition - transform.position;
        if(chaseDir.magnitude < chaseTriggerDistance)
        {
            chaseDir.Normalize();
            GetComponent<Rigidbody2D>().velocity = chaseDir * chasespeed;

        }
        else if (GoHome)
        {
            if (HomeDir.magnitude < 0.1f)
            {
                transform.position = homePosition;
                GetComponent<Rigidbody2D>().velocity = HomeDir * chasespeed;
            }
            else
            {
                HomeDir.Normalize();
                GetComponent<Rigidbody2D>().velocity = HomeDir * chasespeed;
            }
           
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }

        
    }
}
