using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mass : MonoBehaviour
{
    public float Value;

    public void Death()
    {        
        Destroy(gameObject);
    }
}
