using System;
using Builders;
using GameEngineUsage;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private Creator _creator;
    public int healerHp;
    public int healerSpeed;
    public int healerDistance;
    public int healerStrength;
    public int killerHp;
    public int killerSpeed;
    public int killerDistance;
    public int killerStrength;
    public Vector3 redKillerPos;
    public Vector3 redHealerPos;
    public Vector3 blueHealerPos;
    public Vector3 blueKillerPos;

    private void Start()
    {
        _creator = new Creator();
        _creator.HealerHp = healerHp;
        _creator.HealerSpeed = healerSpeed;
        _creator.HealerDistance = healerDistance;
        _creator.HealerStrength = healerStrength;
        _creator.KillerHp = killerHp;
        _creator.KillerSpeed = killerSpeed;
        _creator.KillerDistance = killerDistance;
        _creator.KillerStrength = killerStrength;
    }

    public void RedHealer()
    {
        var now = _creator.GetHealer(1);
        now.moveTo(new MyVector3(redHealerPos));
    }

    public void RedKiller()
    {
        var now = _creator.GetKiller(1);
        now.moveTo(new MyVector3(redKillerPos));
    }

    public void BlueHealer()
    {
        var now = _creator.GetHealer(2);
        now.moveTo(new MyVector3(blueHealerPos));
    }

    public void BlueKiller()
    {
        var now = _creator.GetKiller(2);
        now.moveTo(new MyVector3(blueKillerPos));
    }
}