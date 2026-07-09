using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectiblesMudartela : MonoBehaviour
{
    public float rotationSpeed = 0.5f;
    public GameObject onCollectEffect;

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0, 0, rotationSpeed);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        // Check if the other object has a PlayerController2D component
        if (other)
        {

            // Destroy the collectible
            Destroy(gameObject);

            SceneManager.LoadScene(0);


            // Instantiate the particle effect
            // Instantiate(onCollectEffect, transform.position, transform.rotation);
        }


         public void TrocarSceneInicio()
    {
        SceneManager.LoadScene(0);
    }
}


}
