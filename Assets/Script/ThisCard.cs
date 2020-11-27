using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThisCard : MonoBehaviour
{
    public List<Card> thisCard = new List<Card>();
    public int ThisID;

    public int ID;
    public string CardName;
    public int Cost;
    public int Power;
    public string CardDescription;

    public Text NameText;
    public Text CostText;
    public Text PowerText;
    public Text DescritionText;

    public Sprite ThisSprite;
    public Image ThisImage;

    public bool CardBack;
    public static bool StaticCardBack;

    //Start is called before the first frame update
    void Start()
    {
        thisCard[0] = CardDataBase.CardList[ThisID];
    }

    // Update is called once per frame
    void Update()
    {
        ID = thisCard[0].ID;
        CardName = thisCard[0].CardName;
        Cost = thisCard[0].Cost;
        Power = thisCard[0].Power;
        CardDescription = thisCard[0].CardDescription;

        ThisSprite = thisCard[0].ThisImage;
        ThisImage.sprite = ThisSprite;
        

        NameText.text=""+CardName;
        CostText.text = "" + Cost;
        PowerText.text = "" + Power;
        DescritionText.text = "" + CardDescription;

        StaticCardBack = CardBack;
    }
}
