using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Selection : MonoBehaviour
{
    [SerializeField] Camera cameraMain;
    [SerializeField] GameObject whiteSphere;
    [SerializeField] BoardController boardController;
    [SerializeField] GameObject marker;
    public RaycastHit hit;
    public Vector3 selectionPosition;
    public int selectedPlace;
    public int selectedSphere;
    public Vector3 sphereMove;
    WhiteSphereScript whiteSphereScript;
    Ray ray;
    private int[] possibleMoves;
    private bool canMove;

    Vector3 cameraPosition;
    Vector3 cameraPositionRay;
    public int movePlace;
    //GameObject selectedSphere;

    public int[] adjacentPlaces = new int[6];


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

            
            // if(!canMove){
            selectedPlace = selectedSphere;
            // }else{
            //     selectedPlace = 122;
            // }

            CalculateSelection();
        }
        if(Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out hit, 100f);
            //Debug.Log(boardController.whiteSpherePosition[1]);
            

            for (int i = 0; i < adjacentPlaces.Length; i++)
            {
                if(adjacentPlaces[i] == int.Parse(hit.transform.name))
                {
                    if(canMove)
                    {
                        movePlace = int.Parse(hit.transform.name);
                    }
                }
                
            }
            
        }
    }
    bool CheckPlace(){
        for (int i = 0; i<=8; i++){
            if(boardController.whiteSpherePosition[i] == selectedSphere || boardController.blackSpherePosition[i] == selectedSphere)
            {
                Debug.Log("tak");
                canMove = false;
            }else{
                canMove = true;
                Debug.Log("nie");
            }
        }
        return canMove;
    }
    public void CalculateSelection(){
        adjacentPlaces[0] = selectedPlace - 1;
        adjacentPlaces[1] = selectedPlace + 1;
        adjacentPlaces[2] = selectedPlace + 11;
        adjacentPlaces[3] = selectedPlace - 11;
        adjacentPlaces[4] = selectedPlace + 12;
        adjacentPlaces[5] = selectedPlace - 12;
        for (int i = 0; i < adjacentPlaces.Length; i++)
        {
            string MarkerName = adjacentPlaces[i].ToString();
            GameObject markerPlace = GameObject.Find(MarkerName);
            Vector3 matkerPosition = markerPlace.transform.position;
            Instantiate(marker, matkerPosition, Quaternion.identity);
        }
    
    }

    // public void CalculateSelection(){
    //     string xString = selectedPlace.Substring(0, 1);
    //     string yString = selectedPlace.Substring(2, 1);
    //     string zString = selectedPlace.Substring(4, 1);
    //     int x = Int32.Parse(xString);
    //     int y = Int32.Parse(yString);
    //     int z = Int32.Parse(zString);
    //     Debug.Log(x);
        

    //     adjacentPlaces = new string[10];
    // }
    int CheckSelection(){
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out hit, 100f);
            if(hit.collider != null){
                selectedSphere = int.Parse(hit.transform.name);
            }
            return  selectedSphere;
    }

}
