using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapOnTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Debug.Log("Trap hit payer");
        }
    }
}
