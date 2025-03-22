using UnityEngine;

public class Enemigo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")){
            Destroy(collision.gameObject, 0.2f);
        }
    }
}
