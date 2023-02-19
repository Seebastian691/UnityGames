using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Selection : MonoBehaviour
{
    [SerializeField] Camera cameraMain;
    [SerializeField] GameObject whiteSphere;
    [SerializeField] LayerMask whiteSphereLayer;
    [SerializeField]GameController gameController;
    public RaycastHit hit;
    public Vector3 selectionPosition;
    public string selectedPlace;
    public Vector3 sphereMove;
    WhiteSphereScript whiteSphereScript;
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
            whiteSphereScript = selectedSphere.GetComponent<WhiteSphereScript>();
            selectedPlace = hit.transform.name;
            CheckPlace();
            
            //Debug.Log(hit.transform.name);

        }
        if(Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out hit, 100f);
            movePlacePoint = GameObject.Find(hit.transform.name);
            sphereMove = selectedSphere.transform.position;
            sphereMove = Vector3.MoveTowards(sphereMove, movePlacePoint.transform.position, 2 * Time.deltaTime);
            Debug.Log("tak");
        }
    }
    void CheckPlace(){
        for (int i = 0; i <= 8; i++)
        {
            if(gameController.whiteSpherePosition[i] == selectedPlace){
                Debug.Log("tak");
            }
            if(gameController.blackSpherePosition[i] == selectedPlace){
                Debug.Log("tak");
            }

        }
    void CalculateSelection(){
        string xString = selectedPlace.Substring(0, 1);
        string yString = selectedPlace.Substring(2, 1);
        string zString = selectedPlace.Substring(4, 1);
        int x = Int32.Parse(xString);
        int y = Int32.Parse(yString);
        int z = Int32.Parse(zString);
        Debug.Log(x);
    }
    }

}
