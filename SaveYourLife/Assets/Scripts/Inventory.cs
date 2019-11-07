using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private bool bstick = false;
    private bool brope = false;
    private bool bstone = false;
    private bool baxe = false;
    private int score = 0;
    private int stars = 0;
    public GameObject Stick;
    public GameObject Rope;
    public GameObject Stone;
    public GameObject Axe;
    private bool Key = false;
    //Faire un get et set pour le havestick et quand on set afficher en meme temps sur la caméra
    private void Start()
    {
        Stick.gameObject.SetActive(false);
        Rope.gameObject.SetActive(false);
        Stone.gameObject.SetActive(false);
        Axe.gameObject.SetActive(false);
    }
    private void Update()
    {
        print("HAVE STICK: " + bstick);
        print("HAVE ROPE: " + brope);
        print("HAVE STONE: " + bstone);
        print("HAVE AXE: " + baxe);
        if (bstick)
            Stick.gameObject.SetActive(true);
        if (brope)
            Rope.gameObject.SetActive(true);
        if (bstone)
            Stone.gameObject.SetActive(true);
        if (bstick && brope && bstone)
        {
            Stick.gameObject.SetActive(false);
            Rope.gameObject.SetActive(false);
            Stone.gameObject.SetActive(false);
            Axe.gameObject.SetActive(true);
            SetAxe();
        }


    }
    public int returnScore() { return score; }
    public void addScore(int addscore) { score += addscore; }
    public void addStar() { stars++; }
    public int nbStars() { return stars; }
    public void SetKey() { Key = true; }
    public bool HaveKey() { return Key; }
    public void SetStick() { bstick = true; }
    public bool HaveStick() { return bstick; }
    public bool HaveRope() { return brope; }
    public void SetRope() { brope = true; }
    public bool HaveStone() { return bstone; }
    public void SetStone() { bstone = true; }

    public bool HaveAxe() { return baxe; }
    public void SetAxe() { baxe = true; }
}
