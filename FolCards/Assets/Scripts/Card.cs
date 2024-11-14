using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Card{
    public int id;
    public string title;
    public int cost;
    public int power;
    public int hp;
    [TextArea(3,10)]
    public string description;
    public Sprite img;

    public Card(int id, string title, int cost, int power, int hp, string description, Sprite img){
        this.id = id;
        this.title = title;
        this.cost = cost;
        this.power = power;
        this.hp = hp;
        this.description = description;
        this.img = img;
    }

    public void Print(){
        Debug.Log(title +  ": " + description + " Custo: " + cost);
    }
}
