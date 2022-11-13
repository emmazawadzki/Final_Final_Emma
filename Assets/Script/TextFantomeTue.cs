using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextFantomeTue : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textComponent;

    //Affiche le nombre de fantome tué actuellement
    public void Update(){
        textComponent.text = FantomeCount.nom[0];
        textComponent.text += " : ";
        textComponent.text += FantomeCount.nbFantome[0].ToString();
    }
}