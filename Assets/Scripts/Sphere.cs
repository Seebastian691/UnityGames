using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField] string startingPlace = "2.2.2";
    string currentPlace;
    GameObject boardPlace;
    Vector3 move;
    [SerializeField] float moveSpeed;


    



    void Update()
    {
        currentPlace = startingPlace;
        boardPlace = GameObject.Find(currentPlace);
        move = boardPlace.transform.position;
        //Debug.Log(boardPlace.transform);
        transform.position = Vector3.MoveTowards(transform.position, move, moveSpeed * Time.deltaTime);

    }
}
