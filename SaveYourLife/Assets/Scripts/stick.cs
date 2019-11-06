using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stick : INTERACTION_CLICK_AND_PICK
{
    public GameObject player;

    public override void Start()
    {
        Help.text = descriptionAction;
    }

    override public void Object_Picked()
    {
        if (!player.GetComponent<Inventory>().haveStick)
        {
            player.GetComponent<Inventory>().haveStick = true;
            Destroy(this.gameObject);
        }
    }
}
