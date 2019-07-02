using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changename : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            var textmeshPro = GetComponent<TMPro.TextMeshProUGUI>();
        textmeshPro.SetText("Hello World from Cristian Cruz"); 
        }
    }
}