using System;
using System.Collections;
using System.Collections.Generic;
using Builders;
using GameEngineUsage;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    Creator x = new Creator();

    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnMouseDown()
    {
        x.GetKiller(10).moveTo(new MyVector3(5, 2, 5));
        x.GetHealer(10).moveTo(new MyVector3(10, 2, 5));
    }

    // Update is called once per frame
    void Update()
    {
    }
}