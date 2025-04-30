using JetBrains.Annotations;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float RotationSpeed;
    public GameObject OnCollectEffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.Rotate(0, RotationSpeed, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Destroy the collectible
            Destroy(gameObject);

            //Instantiate the particle effect
            Instantiate(OnCollectEffect, transform.position, transform.rotation);
        }

    }
}
