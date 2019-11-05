using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    public GameObject player;

    public GameObject destroyedVersion;
    public int magnitude = 2;
    public bool clickDestroy = false;
    private void OnMouseDown()
    {
      if (clickDestroy && player.GetComponent<Inventory>().haveStick)
      {
            Instantiate(destroyedVersion, transform.position, transform.rotation);
            Destroy(gameObject);
      }
    }
}