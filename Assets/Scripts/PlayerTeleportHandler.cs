using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class PlayerTeleportHandler : MonoBehaviour
{
    
    public string targetScene;

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Teleporter"))
        {
            
            if (!string.IsNullOrEmpty(targetScene))
            {
                
                SceneManager.LoadScene(targetScene);
            }
            else
            {
                Debug.LogWarning("Target scene is not set in the Inspector!");
            }
        }
    }
}
