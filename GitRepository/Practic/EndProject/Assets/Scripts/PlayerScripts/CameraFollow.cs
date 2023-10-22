using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraFollow : MonoBehaviour
{
    
    [SerializeField] Transform targetTransform;
    //[SerializeField] private float _smooth = 0.20f;
    void FixedUpdate()
    {
        this.transform.position = new Vector3(targetTransform.position.x, targetTransform.position.y , this.transform.position.z);
    }
}
