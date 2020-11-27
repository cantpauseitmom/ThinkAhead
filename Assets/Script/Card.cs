using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card
{
    public int ID;
    public string CardName;
    public int Cost;
    public int Power;
    public string CardDescription;

    public Sprite ThisImage;

    public Card()
    {

    }

    // Update is called once per frame
    public Card(int iD, string cardName, int cost, int power, string cardDescription, Sprite thisImage)
    {
        ID = iD;
        CardName = cardName;
        Cost = cost;
        Power = power;
        CardDescription = cardDescription;
        ThisImage = thisImage;
    }
}
