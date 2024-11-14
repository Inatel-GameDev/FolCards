using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandCard : MonoBehaviour
{
    public GameObject Hand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Hand = GameObject.Find("Hand");
        transform.SetParent(Hand.transform);
        transform.localScale = Vector3.one;
        transform.position = new Vector3(transform.position.x, transform.position.y, -48);
        transform.eulerAngles = new Vector3(25,0,0);
    }
}
