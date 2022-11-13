using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextPartieFinie : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textComponent1;
    [SerializeField] private TextMeshProUGUI textComponent2;
    [SerializeField] private TextMeshProUGUI textComponent3;

    
    public void Update(){
        //Affichage des scores de la partie joué
        textComponent1.text = "Sur " + FantomeCount.nbFantome[2].ToString() + " Fantômes :";
        textComponent2.text = "     " + FantomeCount.nbFantome[0].ToString() + " Fantômes ont été tué";
        textComponent3.text = "     Votre score est de " + FantomeCount.nbFantome[1].ToString() + " points";
    }
}
