using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerBehavior : MonoBehaviour
{   
    [SerializeField] HealthBarScript healthbar;
    [SerializeField] HealthBar playerhealth;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // test for system working
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            PlayerTakeDmg(10);
            Debug.Log(GameManager.gameManager.playerHealth.Health);
        }
        if(Input.GetKeyDown(KeyCode.RightShift))
        {
            PlayerHeal(10);
            Debug.Log(GameManager.gameManager.playerHealth.Health);

        }
        
    }

    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            PlayerTakeDmg(10);
        }

    
    }
    
    
    private void PlayerTakeDmg(int dmg) 
    {
        GameManager.gameManager.playerHealth.DmgUnit(dmg);
        healthbar.SetHealth(GameManager.gameManager.playerHealth.Health);
    }

    private void PlayerHeal(int healing) 
    {
        GameManager.gameManager.playerHealth.HealUnit(healing);
        healthbar.SetHealth(GameManager.gameManager.playerHealth.Health);

    }
}
