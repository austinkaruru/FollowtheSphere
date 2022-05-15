using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{   
    [SerializeField] float moveSpeed = 10f; 

    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
}
}
