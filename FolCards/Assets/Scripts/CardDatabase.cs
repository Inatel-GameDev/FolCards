using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    public void Awake(){

        cardList.Add(new Card(0, "Marcelinho Carioca", 1, 2, 3, "Meu corpo é duro, o chão é mole e você continua feio", Resources.Load<Sprite>("Marcelo")));
        cardList.Add(new Card(1, "None1", 1, 2, 3, "Good", Resources.Load<Sprite>("Marcelo")));
        cardList.Add(new Card(2, "None2", 1, 2, 3, "Alves??", Resources.Load<Sprite>("Alves")));
        cardList.Add(new Card(3, "Non3", 1, 2, 3, "Vitihho", Resources.Load<Sprite>("Alves")));
    }
}
