using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteSphereScript : MonoBehaviour
{
[SerializeField] BoardController boardController;
    private string startingPlace;
    [SerializeField] int whitephereIndex;
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
        // startingPlace = gameController.blackSpherePosition[blackSphereIndex];

    }
    


    void Update()
    {
        currentPlace = boardController.whiteSpherePosition[whitephereIndex];
        boardPlace = GameObject.Find(currentPlace);
        move = boardPlace.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, move, moveSpeed * Time.deltaTime);
    }
}
