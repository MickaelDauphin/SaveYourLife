﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : INTERACTION_CLICK_AND_PICK
{
    public GameObject player;

    public override void Start()
    {
        Help.text = descriptionAction;
    }

    override public void Object_Picked()
    {
        print(player.GetComponent<Inventory>().HaveTorch());
        if (!player.GetComponent<Inventory>().HaveTorch())
        {
            player.GetComponent<Inventory>().SetTorch();
            Destroy(this.gameObject);
        }
    }
}