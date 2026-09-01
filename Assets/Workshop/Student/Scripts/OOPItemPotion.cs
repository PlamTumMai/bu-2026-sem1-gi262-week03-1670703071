using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OOPItemPotion : Identity
{
    public int healPoint;
    public bool isBonus;

    public void Start()
    {
        
    }

    public override void Hit()
    {
        Destroy(gameObject);
        mapGenerator.player.Heal(healPoint);
        mapGenerator.mapdata[positionX, positionY] = mapGenerator.empty;
    }
}