using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    public static int maxHp;
    public static int staticHp;
    public float hp;
    public Image avatar;
    public Image health;
    public TMP_Text hpText;
    // Start is called before the first frame update
    void Start()
    {
        maxHp = 100;
        staticHp = 100;
    }

    // Update is called once per frame
    void Update()
    {
        //hp = staticHp;
        health.fillAmount = hp/maxHp;
        Debug.Log(hp/maxHp);
        if(hp >= maxHp){ //Faz com clamp depois quando vc tiver um pc de verdade
            hp = maxHp;
        }
        if(hp <= 0){
            hp = 0;
        }
        hpText.text = hp + "";
    }
}
