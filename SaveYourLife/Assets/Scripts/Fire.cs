using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : INTERACTION_CLICK_AND_PICK
{
    public GameObject player;
    public ParticleSystem particle;
    private void Start()
    {
        particle.Stop();
    }
    private void OnMouseDown()
    {
        if (player.GetComponent<Inventory>().HaveTorch() && player.GetComponent<Inventory>().StrawTop)
        {
            particle.Play();
            player.GetComponent<Inventory>().Torch.SetActive(false);
            base.Declencher_Etape_Suivante_Du_Scenario();
        }
    }
}
