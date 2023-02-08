using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Transform zoomOutTarget;
    [SerializeField] Transform zoomInTarget;
    [SerializeField] float zoomSpeed;

    void Update()
    {
        transform.LookAt(target);

        if(Input.GetAxisRaw("Vertical")>0.1f){
            transform.position = Vector3.Lerp(transform.position, zoomInTarget.position, zoomSpeed * Time.deltaTime);
        }
        if(Input.GetAxisRaw("Vertical")<0f){
            transform.position = Vector3.Lerp(transform.position, zoomOutTarget.position, zoomSpeed * Time.deltaTime);
        }
    }
}
