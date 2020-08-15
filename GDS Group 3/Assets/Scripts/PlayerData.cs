using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class PlayerData
{
    public int count;
    public float[] position;

    public PlayerData (MainPlayerFunctions countText)
    {
        count = countText.count;
    }
    public PlayerData (PlayerOverlord player)
    {
        position = new float[3];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;
    }
}
