using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    
    public float maxSpeed = 5f;

    void Update()
    {
        
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        
        mousePosition.z = 0;

        
        Vector3 direction = mousePosition - transform.position;

        
        if (direction.magnitude > 0.1f) 
        {
            
            transform.position = Vector3.MoveTowards(transform.position, mousePosition, maxSpeed * Time.deltaTime);
        }
    }
}
