using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    public GameObject Money;
    public int score = 0;
    public int lvl = 1;
    public int numM=1;
    public Text numMoney;
    public Text money;
    public Text textlvl;
    public Text upgradeLvl;
    public Button lvlUp;
    public Button Score;
    public int price = 5;

    private void Start()
    {
        lvlUp.enabled = false;
        upgradeLvl.text = "UPGRADE" + price.ToString();
        textlvl.text = "LVL 1" ;
        numMoney.text = "+ " + numM.ToString();
        money.text = score.ToString();
        Score.onClick.AddListener(Spawn);
    }
    
    // Update is called once per frame
    void Update()
    {
        textlvl.text = "LVL " + lvl.ToString();
        upgradeLvl.text = "UPGRADE " + price.ToString();
        numMoney.text = "+ " + numM.ToString();
        money.text = score.ToString();
        
    }
    void Spawn()
    {
         Instantiate(Money);
        
        
        
    }
    public void Click()
    {
        score += numM;
       
        if (score >= price) lvlUp.enabled = true;
        else lvlUp.enabled = false;

    }

    public void UpgradeClick()
    {
       
        if (score >= price)
        {

            score -= price;
            price += 7*lvl;
            numM+=2;
            lvl++;
        }
       
    }
}
