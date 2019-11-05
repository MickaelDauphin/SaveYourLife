using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stick : MonoBehaviour
{
    public GameObject player;

    private void OnMouseDown()
    {
        player.GetComponent<Inventory>().haveStick = true;
        Destroy(this.gameObject);
    }
}