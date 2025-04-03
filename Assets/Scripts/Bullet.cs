using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody bulletRb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bulletRb = GetComponent<Rigidbody>();
        bulletRb.linearVelocity = transform.forward * speed;
        
        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController playerController = other.GetComponent<PlayerController>();
            if (playerController != null)
            {
                playerController.Die();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
