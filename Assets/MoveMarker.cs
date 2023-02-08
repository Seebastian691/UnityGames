using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMarker : MonoBehaviour
{
    Selection selectionScript;
    [SerializeField] GameObject cameraMain;
    // Start is called before the first frame update
    void Awake()
    {
        selectionScript = cameraMain.GetComponent<Selection>();
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = selectionScript.selectionPosition;
        //Debug.Log(selectionScript.hit.transform.name);
    }
}
