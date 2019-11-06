using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Bonus : MonoBehaviour
{
    public Text Score_UIText;
    private bool isDo = false;
    public GameObject Player;

    void Update()
    {
        Score_UIText.text = "score : " + Player.GetComponent<Inventory>().returnScore();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !isDo)
        {
            isDo = true;
            other.GetComponent<Inventory>().addScore(100);
            Destroy(this.gameObject);
        }
    }

}
