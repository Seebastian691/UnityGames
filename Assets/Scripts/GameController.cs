using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameController : MonoBehaviour
{
    [SerializeField] GameStartPosition startPosition;
    public string[] whiteSpherePosition;
    public string[] blackSpherePosition;

    // Selection selectionScript;
    // [SerializeField] GameObject cameraMain;

    // // Start is called before the first frame update
    // void Awake()
    // {
    //     selectionScript = cameraMain.GetComponent<Selection>();
    // }



    void Start()
    {
        SetStartingPosition();
    }

    // void Update()
    // {
    //     selectionScript.CalculateSelection();
    // }

    
    void SetStartingPosition()
    {
        for (int i = 0; i <= 8; i++)
        {
            whiteSpherePosition[i] = startPosition.WhiteStartPosition[i];
            blackSpherePosition[i] = startPosition.BlackStartPosition[i];
        }
    }
}
