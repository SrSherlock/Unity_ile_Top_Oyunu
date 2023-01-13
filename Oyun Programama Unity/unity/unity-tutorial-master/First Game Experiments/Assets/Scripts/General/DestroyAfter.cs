using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfter : MonoBehaviour
{
    [SerializeField]
    float fTimer;
 
    void Update()
    {
        // patlama efekti
        fTimer -= Time.deltaTime;
        if (fTimer <= 0)
            Destroy(this.gameObject);        
    }
}
