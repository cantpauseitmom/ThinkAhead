using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDataBase : MonoBehaviour
{
    public static List<Card> CardList = new List<Card>();
    private void Awake()
    {
        CardList.Add(new Card(0,"Pawel",1,1,"Lubi programowac.", Resources.Load<Sprite>("bg")));
        CardList.Add(new Card(1,"Hubert",1,1,"Lubi projektowac.", Resources.Load<Sprite>("bg")));
        CardList.Add(new Card(2,"Michał",1,1,"Lubi malowac.", Resources.Load<Sprite>("bg")));

    }
}
