using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastStep : INTERACTION_CLICK_AND_PICK
{
    private bool bStraw;
    public GameObject Straw;
    public GameObject player;
    public GameObject Fire;
    public Camera CameraPlayer;
    public Camera CameraEnd;
    private bool bFire;
    public override void Object_Picked()
    {
        if (player.GetComponent<Inventory>().HaveStraw())
        {
            player.GetComponent<Inventory>().SetStraw(false);
            Straw.gameObject.SetActive(true);
            bFire = true;
        }
        else if(bFire && player.GetComponent<Inventory>().HaveTorch())
        {
            Fire.gameObject.SetActive(true);
            CameraPlayer.gameObject.SetActive(false);
            CameraEnd.gameObject.SetActive(true);
            if(CameraEnd.GetComponent<Animator>().playbackTime)

            //base.Declencher_Etape_Suivante_Du_Scenario();
        }
    }
}
