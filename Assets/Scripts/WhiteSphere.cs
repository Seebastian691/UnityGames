using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteSphereScript : MonoBehaviour
{
    [SerializeField]GameController gameController;
    private string startingPlace;
    [SerializeField] int whiteSphereIndex;
    string currentPlace;
    GameObject boardPlace;
    Vector3 move;
    [SerializeField] float moveSpeed;


    
    void Start()
    {
        
        // string xString = startingPlace.Substring(0, 1);
        // string yString = startingPlace.Substring(2, 1);
        // string zString = startingPlace.Substring(4, 1);
        // int x = Int32.Parse(xString);
        // int y = Int32.Parse(yString);
        // int z = Int32.Parse(zString);
        //Debug.Log(x);
        startingPlace = gameController.whiteSpherePosition[whiteSphereIndex];

    }
    


    void Update()
    {
        currentPlace = startingPlace;
        boardPlace = GameObject.Find(startingPlace);
        move = boardPlace.transform.position;
        //Debug.Log(boardPlace.transform);
        transform.position = Vector3.MoveTowards(transform.position, move, moveSpeed * Time.deltaTime);

    }
}
