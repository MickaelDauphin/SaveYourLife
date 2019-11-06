using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private bool bstick = false;
    private int score = 0;
    private int stars = 0;
    public GameObject Stick;
    private bool Key = false;
    //Faire un get et set pour le havestick et quand on set afficher en meme temps sur la caméra
    private void Start()
    {
        Stick.gameObject.SetActive(false);
    }
    private void Update()
    {
        print("HAVE STICK: " + bstick);
        if (bstick)
            Stick.gameObject.SetActive(true);
    }
    public int returnScore() { return score; }
    public void addScore(int addscore) { score += addscore; }
    public void addStar() { stars++; }
    public int nbStars() { return stars; }
    public void SetKey() { Key = true; }
    public bool HaveKey() { return Key; }
    public void SetStick() { bstick = true; }
    public bool HaveStick() { return bstick; }
}
