using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection : MonoBehaviour
{
    [SerializeField] Camera cameraMain;
    [SerializeField] GameObject whiteSphere;
    [SerializeField] LayerMask whiteSphereLayer;
    public RaycastHit hit;
    public Vector3 selectionPosition;
    public Vector3 sphereMove;

    Ray ray;

    Vector3 cameraPosition;
    Vector3 cameraPositionRay;
    GameObject movePlacePoint;
    GameObject selectedSphere;
    //Camera camera;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            // RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out hit, 100f);
            selectedSphere = GameObject.Find(hit.transform.name);

            selectionPosition = selectedSphere.transform.position;
            Debug.Log(hit.transform.name);

        }
        if(Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out hit, 100f);
            movePlacePoint = GameObject.Find(hit.transform.name);
            sphereMove = selectedSphere.transform.position;
            selectedSphere.transform.position = Vector3.MoveTowards(sphereMove, movePlacePoint.transform.position, 2 * Time.deltaTime);
        }
    }
}
