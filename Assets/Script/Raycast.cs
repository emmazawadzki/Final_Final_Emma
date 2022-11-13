using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textComponent;
    
    //Permet d'afficher un message lorsque un Fantome est situé au niveau du Raycast
    private void Update(){
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, 30f)){
            //Si le nom de l'objet touché par le raycasy est "Fantome(Clone)" on affiche un message 
            if(hit.transform.name=="Fantome(Clone)"){
                textComponent.text = "Tire !! Tu vas le manquer";
            }
            else{
                textComponent.text = "";
            }
            
        }
    }

}
