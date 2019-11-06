using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Destructible : INTERACTION_CLICK_AND_PICK
{
    public GameObject player;
    public Text Info;
    public GameObject destroyedVersion;
    public int magnitude = 2;

    public override void Start()
    {
        Help.text = descriptionAction;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.relativeVelocity.magnitude > magnitude)
        {
            Instantiate(destroyedVersion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    override public void Object_Picked()
    {
        if (player.GetComponent<Inventory>().HaveStick())
        {
            Info.text = "Vous avez trouvé la Clef !!";
            Info.enabled = true;
            player.GetComponent<Inventory>().SetKey();
            Instantiate(destroyedVersion, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
