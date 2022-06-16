using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIDisplay : MonoBehaviour
{
    [SerializeField] UI config;
    [SerializeField] TMP_Text text;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void item1(int number)
    {
        Debug.Log(config.itemDescription[number]);
        text.text = config.itemDescription[number];
    }
}
