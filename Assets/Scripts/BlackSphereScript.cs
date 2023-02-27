using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackSphereScript : MonoBehaviour
{
    [SerializeField] BoardController boardController;
    private string startingPlace;
    [SerializeField] int blackSphereIndex;
    int currentPlace;
    string placeName;
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
        // startingPlace = gameController.blackSpherePosition[blackSphereIndex];

    }
    


    void Update()
    {
        currentPlace = boardController.blackSpherePosition[blackSphereIndex];
        placeName = currentPlace.ToString();
        boardPlace = GameObject.Find(placeName);
        move = boardPlace.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, move, moveSpeed * Time.deltaTime);

    }
}
