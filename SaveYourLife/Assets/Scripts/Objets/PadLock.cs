using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadLock : INTERACTION_CLICK_AND_PICK
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject locker;
    public GameObject m_Door1;
    public GameObject m_Door2;
    public bool DoubleDoor;

    public override void Start()
    {
        Help.text = descriptionAction;
    }

    override public void Object_Picked()
    {
        if (player.GetComponent<Inventory>().HaveKey())
        {
            m_Door1.gameObject.GetComponent<Door>().CanOpen = true;
            if (DoubleDoor)
            {
                m_Door2.gameObject.GetComponent<Door>().CanOpen = true;
            }
            Destroy(locker);
            base.Declencher_Etape_Suivante_Du_Scenario();
            Destroy(this.gameObject);
        }
    }
}
