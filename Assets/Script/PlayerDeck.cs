using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    public List<Card> Deck = new List<Card>();
    public int DeckSize;
    int x;
    void Start()
    {
        
        x = 0;
        for(int i = 0; i < DeckSize; i++)
        {
            x = Random.Range(0,3);
            Deck.Add(CardDataBase.CardList[x]);
        }
    }

}
