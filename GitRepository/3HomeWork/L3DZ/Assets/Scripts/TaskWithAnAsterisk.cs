using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskWithAnAsterisk : MonoBehaviour
{
    [SerializeField] Health health;
    private void Start()
    {        
        CheckTask();
    }

    public void CheckTask()
    {
        health.TakeDamage(30);             
    }
}
