using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    int health = 10;
    [SerializeField]
    string leveltoload = "lose";
    int maxHP;
    [SerializeField]
    Image healthBar;
    // Start is called before the first frame update
    void Start()
    {
        maxHP = health;
        healthBar.fillAmount = health / maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        //IF we hit an enemy, reduce player health
        if(collision.gameObject.name == "Enemy")
        {
            health -= 1; 
            // add consenquences 
            // if health gets too low, relod the current level 
            if(health <=  0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
               // SceneManager.LoadScene(leveltoload)
            }
        }

    }
}
