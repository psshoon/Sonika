using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    List<List<GameObject>> tilesList = new List<List<GameObject>>();
    public int numberOfXtile = 0, numberOfZtile = 0;

    private void Awake()
    {
        makeTiles(numberOfXtile, numberOfZtile);
    }

    void makeTiles(int x, int z)
    {
        for(int i = 0; i < z; i++)
        {
            tilesList.Add(new List<GameObject>());
            for (int j = 0; j < x; j++)
            {
                //GameObject tile;
                //if (tile = Instantiate(Resources.Load("Prefeb/Tile") as GameObject))
                //{
                //    tile.transform.SetPositionAndRotation(new Vector3(j - 2, -1, i * 2), new Quaternion());
                //    tilesList[i].Add(tile);
                //}
                //else
                //{
                //    Debug.Log("false");
                //    break;
                //}
                GameObject tile = Instantiate(Resources.Load("Prefeb/Tile") as GameObject);
                tile.transform.SetPositionAndRotation(new Vector3(j - 2, -1, i * 2), new Quaternion());
                tilesList[i].Add(tile);

            }
        }
    }
}
