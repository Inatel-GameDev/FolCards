using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TurnSystem : MonoBehaviour
{
    public bool myTurn;
    public int yourTurn;
    public int opTurn;
    public TMP_Text turnText;
    
    public int maxMana;
    public int currentMana;
    public TMP_Text manaText;

    public static bool startTurn;
    void Start()
    {
        myTurn = true;
        maxMana = currentMana = 1;
        yourTurn = 1;
        opTurn = 0;
        startTurn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(myTurn){
            turnText.text = "Seu turno";
        }else{
            turnText.text = "Turno do Oponente";
        }
        manaText.text = currentMana + "/" + maxMana;
    }

    public void EndYourTurn(){
        myTurn = false;
        opTurn += 1;
    }

    public void EndOpsTurn(){
        myTurn = true;
        yourTurn += 1;
        maxMana += 1;
        currentMana = maxMana;
        startTurn = true;
    }
}
