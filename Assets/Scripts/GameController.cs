using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameController : MonoBehaviour
{
    [SerializeField] GameStartPosition startPosition;
    public string[] whiteSpherePosition;
    public string[] blackSpherePosition;
    



    void Start()
    {
        SetStartingPosition();
    }

    
    void SetStartingPosition()
    {
        for (int i = 0; i <= 8; i++)
        {
            whiteSpherePosition[i] = startPosition.WhiteStartPosition[i];
        }

        for (int i = 0; i <= 8; i++)
        {
            blackSpherePosition[i] = startPosition.BlackStartPosition[i];
        }
    }
}
