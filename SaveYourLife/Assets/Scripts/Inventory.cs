﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private bool bstick = false;
    private bool brope = false;
    private bool bstone = false;
    private bool baxe = false;
    private bool bstraw = false;
    private bool btorch = false;
    private int score = 0;
    private int stars = 0;
    public GameObject Stick;
    public GameObject Rope;
    public GameObject Stone;
    public GameObject Axe;
    public GameObject Straw;
    public GameObject Torch;
    private bool Key = false;
    private bool isDo = false;
    private bool isDo2 = false;
    private bool isDo3 = false;
    public bool StrawTop = false;

    //Faire un get et set pour le havestick et quand on set afficher en meme temps sur la caméra
    private void Start()
    {
        Stick.gameObject.SetActive(false);
        Rope.gameObject.SetActive(false);
        Stone.gameObject.SetActive(false);
        Axe.gameObject.SetActive(false);
        Straw.gameObject.SetActive(false);
        Torch.gameObject.SetActive(false);
    }
    private void Update()
    {
        print("HAVE STICK: " + bstick);
        print("HAVE ROPE: " + brope);
        print("HAVE STONE: " + bstone);
        print("HAVE AXE: " + baxe);
        print("HAVE STRAW: " + bstraw);
        print("HAVE TORCH: " + btorch);
        if (bstick && !isDo)
            Stick.gameObject.SetActive(true);
        if (brope && !isDo)
            Rope.gameObject.SetActive(true);
        if (bstone && !isDo)
            Stone.gameObject.SetActive(true);
        if (bstick && brope && bstone && !isDo)
        {
            Stick.gameObject.SetActive(false);
            Rope.gameObject.SetActive(false);
            Stone.gameObject.SetActive(false);
            Axe.gameObject.SetActive(true);
            SetAxe();
            isDo = true;
        }
        if (/*baxe && */bstraw && !isDo2)
        {
            Straw.gameObject.SetActive(true);
            isDo2 = true;
        }
            
        if (/*baxe && */btorch && !isDo3)
        {
            Torch.gameObject.SetActive(true);
            isDo3 = true;
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
    public bool HaveStraw() { return bstraw; }
    public void SetStraw() { bstraw = true; }
    public bool HaveTorch() { return btorch; }
    public void SetTorch() { btorch = true; }
}
