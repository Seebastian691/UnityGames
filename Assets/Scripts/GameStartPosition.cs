using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewStartPosition", menuName = "StartPosition")]
public class GameStartPosition : ScriptableObject
{
    public string[] WhiteStartPosition;
    public string[] BlackStartPosition;
}
