using UnityEngine;

public class Fallingplatform : MonoBehaviour
{
    public Rigidbody rb;

    private void start()
    {
        rb.useGravity = false;
    }
   
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            rb.useGravity = true;
            Debug.Log("Collided with Player");
        }
    }

}
