using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    Animator animatorComponent;
    private void Awake()
    {
        animatorComponent = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            
            animatorComponent.Play("Checkpoint");
            string newPlayerPosition = this.transform.position.ToString();
            newPlayerPosition = newPlayerPosition.Replace("(", "");
            newPlayerPosition = newPlayerPosition.Replace(")", "");
            newPlayerPosition = newPlayerPosition.Replace(" ", "");
            PlayerPrefs.SetString("PlayerPosition", newPlayerPosition);
            Debug.Log(newPlayerPosition);
        }
    }
}
