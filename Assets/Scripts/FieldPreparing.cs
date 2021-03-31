using System;
using GameEngineUsage;
using InGameObjects;
using UnityEngine;

public class FieldPreparing : MonoBehaviour
{
    public GameObject tileExample;

    private void Start()
    {
        for (int i = 0; i < 25; i++)
        {
            for (int j = 0; j < 25; j++)
            {
                GameObject toSpawn = Instantiate(tileExample);
                Tile newTile = new Tile();
                var connector = toSpawn.GetComponent<EngineInformation>();
                connector.unit = newTile;
                newTile.Bridge = connector;
                toSpawn.SetActive(true);
                newTile.moveTo(new MyVector3(i, 0, j));
            }
        }
    }
}