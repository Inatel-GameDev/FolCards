using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class DisplayCard : MonoBehaviour
{
    public List<Card> displayCard = new List<Card>();
    public int displayId;
    public GameObject cardBack;

    public int id;
    public string title;
    public int cost;
    public int power;
    public int hp;
    public string description;
    public Sprite spriteImage;

    public TMP_Text titleText;
    public TMP_Text costText;
    public TMP_Text descriptionText;
    public TMP_Text powerText;
    public TMP_Text hpText;
    public Image artImage;
    public bool isDown;
    public static bool staticCardBack;

    public GameObject hand;
    public int cardsInDeck;

    public void Start()
    {
        cardsInDeck = Deck.deckSize;

        displayCard[0] = CardDatabase.cardList[displayId];
       
    }

    public void Update(){

        Display();

        hand = GameObject.Find("Hand");
        if(this.transform.parent == hand.transform.parent){
            isDown = false;
        }
       staticCardBack = isDown;
       if(staticCardBack){
            cardBack.SetActive(true);
        }else{
            cardBack.SetActive(false);
        }

        if(this.tag == "Clone"){
            displayCard[0] = Deck.staticDeck[cardsInDeck - 1];
            cardsInDeck -= 1;
            Deck.deckSize -= 1;
            isDown = false;
            this.tag = "Untagged";
        }
    }

    public void Display(){
        id = displayCard[0].id;
        title = displayCard[0].title;
        cost = displayCard[0].cost;
        power = displayCard[0].power;
        hp = displayCard[0].hp;
        description = displayCard[0].description;
        spriteImage = displayCard[0].img;

        titleText.text = " " + title;
        costText.text = " " + cost;
        powerText.text = " " + power;
        hpText.text = " " + hp;
        descriptionText.text = " " + description;
        artImage.sprite = spriteImage;
    }

}
