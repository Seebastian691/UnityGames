using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMarker : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
    if(Input.GetMouseButtonDown(0))
        {
            Destroy(gameObject,0);
        }
    }
}
