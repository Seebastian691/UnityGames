using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] float rotateSpeed;
    private float angle;
    void Start()
    {
        
    }

    void Update()
    {
        angle = Input.GetAxis("Horizontal") * -1;
        transform.Rotate(0, angle * Time.deltaTime * rotateSpeed, 0);
    }
}
