using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Selection : MonoBehaviour
{
    [SerializeField] Camera cameraMain;
    [SerializeField] GameObject whiteSphere;
    [SerializeField] LayerMask whiteSphereLayer;
    [SerializeField] BoardController boardController;
    public RaycastHit hit;
    public Vector3 selectionPosition;
    public string selectedPlace;
    public Vector3 sphereMove;
    WhiteSphereScript whiteSphereScript;
    Ray ray;
    public string[] possibleMoves;

    Vector3 cameraPosition;
    Vector3 cameraPositionRay;
    public string movePlace;
    GameObject selectedSphere;

    public string[] adjacentPlaces;

    //Camera camera;


    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            CheckSelection();
            CheckPlace();
            // selectedPlace = new string[1];
            //Debug.Log(hit.transform.name);

        }
        if(Input.GetMouseButtonDown(0))
        {
            CheckSelection();
            CheckPlace();
            // selectedPlace = new string[3];
        }
        if(Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out hit, 100f);
            movePlace = hit.transform.name;
        }
    }
    void CheckPlace(){
        for (int i = 0; i <= 8; i++)
        {
            if(boardController.whiteSpherePosition[i] == selectedPlace || boardController.blackSpherePosition[i] == selectedPlace)
            {

            }
        }
    }
    public void CalculateSelection(){
        string xString = selectedPlace.Substring(0, 1);
        string yString = selectedPlace.Substring(2, 1);
        string zString = selectedPlace.Substring(4, 1);
        int x = Int32.Parse(xString);
        int y = Int32.Parse(yString);
        int z = Int32.Parse(zString);
        Debug.Log(x);
        

        adjacentPlaces = new string[10];
    }
    string CheckSelection(){
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out hit, 100f);
            // selectedSphere = GameObject.Find(hit.transform.name);
            // sphereMove = selectedSphere.transform.position;
            // sphereMove = Vector3.MoveTowards(sphereMove, movePlacePoint.transform.position, 2 * Time.deltaTime);
            selectedPlace = hit.transform.name;
            return  selectedPlace;
    }

}
