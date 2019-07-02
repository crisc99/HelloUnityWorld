<<<<<<< HEAD
﻿using System.Collections;
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
=======
﻿using System.Collections;
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
>>>>>>> 89ad51a692294a1c5975525a9511fd8d3c9bc623
}