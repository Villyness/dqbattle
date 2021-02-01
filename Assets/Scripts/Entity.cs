using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity: MonoBehaviour
{
    // Setting up variables
    public int Health;
    public int MP;
    public int Attack;
    public int Defense;
    public int MagicMight;
    public int MagicMending;
    public int MagicResist;
    public int Speed;

    public Entity()
    {
        Health = 1;
    }
}
