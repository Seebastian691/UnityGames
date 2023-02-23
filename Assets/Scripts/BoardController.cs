using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BoardController : MonoBehaviour
{
    [SerializeField] GameStartPosition startPosition;
    public string[] whiteSpherePosition;
    public string[] blackSpherePosition;

    Selection selectionScript;
    [SerializeField] GameObject cameraMain;

    // Start is called before the first frame update
    void Awake()
    {
        selectionScript = cameraMain.GetComponent<Selection>();
    }



    void Start()
    {
        SetStartingPosition();
    }

    void Update()
    {
        if(Input.GetMouseButtonUp(1))
        {
            for (int i = 0; i <= 8; i++)
        {
            if(whiteSpherePosition[i] == selectionScript.selectedPlace){
                whiteSpherePosition[i] = selectionScript.movePlace;
                
                
            }
            if(blackSpherePosition[i] == selectionScript.selectedPlace){
                blackSpherePosition[i] = selectionScript.movePlace;
            }
        }
            // Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // Physics.Raycast(ray, out hit, 100f);
            // movePlace = hit.transform.name;
            // Debug.Log("tak");
        }
    }

    
    void SetStartingPosition()
    {
        for (int i = 0; i <= 8; i++)
        {
            whiteSpherePosition[i] = startPosition.WhiteStartPosition[i];
            blackSpherePosition[i] = startPosition.BlackStartPosition[i];
        }
    }
}
