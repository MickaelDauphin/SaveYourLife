using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    public GameObject destroyedVersion;
    public int magnitude = 2;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.relativeVelocity.magnitude > magnitude)
        {
            Instantiate(destroyedVersion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
