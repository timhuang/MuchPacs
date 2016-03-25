using UnityEngine;
using System.Collections;

[System.Serializable]
public class PlayerConfig
{
    public float Player_Velocity;
}

public class GameplayConfig : ScriptableObject
{
    public PlayerConfig PlayerConfig;
}

