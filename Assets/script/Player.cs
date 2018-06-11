using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public UnityEngine.UI.Text tips;
    Rigidbody rigid;
    float speed = 7000;
    public int count;
    public UnityEngine.UI.Text score;
    

    Monster monster;

	void Start () {
        rigid = GetComponent<Rigidbody>();	

	}
	
	
	void Update () {
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");

        var movement = new Vector3(h, 0, v);

        rigid.AddForce(movement);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Pickup>())
        {
            other.gameObject.SetActive(false);
            count++;
            RefreshTips();
        }
        if (other.GetComponent<Monster>())
        {
            tips.text = "YouLose!!!!!!!";
            Death();
        }
    }
    
    void RefreshTips()
    {
        score.text = "Score: " + count.ToString();

        if(count >= 11)
        {

            tips.text = "Congratulation!!!!!!!";
            Application.LoadLevel("Level2");
        }
    }
    public void Death()
    {
        
        gameObject.SetActive(false);
    }
}
