using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public List<Card> container = new List<Card>();
    public int x;
    public static int deckSize = 40;
    public List<Card> deck = new List<Card>();
    public static List<Card> staticDeck = new List<Card>();

    public GameObject cardInDeck1;
    public GameObject cardInDeck2;
    public GameObject cardInDeck3;
    public GameObject cardInDeck4;
    public GameObject CardToHand;
    public GameObject[] Clones;
    public GameObject Hand;
    // Start is called before the first frame update
    void Start()
    {
        deckSize = 40;
        Debug.Log(deckSize);
        x = 0;
        for(int i = 0; i < deckSize; i++){
            x = Random.Range(1, 4);
            deck[i] = CardDatabase.cardList[x];
        }

        StartCoroutine(StartGame());

    }

    // Update is called once per frame
    void Update()
    {
        staticDeck = deck;
        if(deckSize < 30){
            cardInDeck1.SetActive(false);
        }
        if(deckSize < 20){
            cardInDeck2.SetActive(false);
        }
        if(deckSize < 10){
            cardInDeck3.SetActive(false);
        }

        if(TurnSystem.startTurn){
            StartCoroutine(Draw(1));
            TurnSystem.startTurn = false;
        }
    }

    public void Shuffle(){
        for(int i = 0; i < deckSize; i++){
            container[0] = deck[i];
            int randomIndex = Random.Range(i, deckSize);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = container[0];
        }
    }

    public IEnumerator StartGame(){
        for (int i = 0; i <= 4; i++){ //Para cada carta que é tirada do deck, mudar 4 depois
            yield return new WaitForSeconds(0.5f);
            //audioSource.PlayOneShot(draw,0.5f);
            Instantiate(CardToHand, transform.position, transform.rotation);
        }
    }

    public IEnumerator Draw(int x){
        for (int i = 0; i < x; i++)
        {
            yield return new WaitForSeconds(0.5f);
            Instantiate(CardToHand, transform.position, transform.rotation);
        }
    }
}
