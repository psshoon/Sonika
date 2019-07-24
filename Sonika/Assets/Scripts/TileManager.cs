using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    List<GameObject[]> tilesList = new List<GameObject[]>();


    private void Awake()
    {
        tilesList[0][0] = new GameObject();
    }
}
