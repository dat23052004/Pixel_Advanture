using UnityEngine;

public class BouncingBulletManager : MonoBehaviour
{
    int touchCount = 0;
    public GameObject hitEffect;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }
        touchCount++;   
        if(touchCount >= 3)
        {
            Instantiate(hitEffect, transform.position, Quaternion.identity,null );
            Destroy(this.gameObject);
        }
    }
}
