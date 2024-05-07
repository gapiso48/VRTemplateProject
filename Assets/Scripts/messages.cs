using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class messages : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text cajaTexto;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateText(string texto)
    {
        cajaTexto.text = texto;
    }
}
