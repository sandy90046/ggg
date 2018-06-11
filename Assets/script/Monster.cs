using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {
    Player player;
    public UnityEngine.UI.Text tips;
    private void OnTriggerEnter(Collider other)
    {

        
        if (tips.text == "Congratulation!!!!!!!")
        {

            
            Death();
        }
        if (other.GetComponent<Player>())
        {
            tips.text = "YouLose!!!!!!!";
        }
    }

    public void Death()
    {
        gameObject.SetActive(false);
    }
}
