using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FantomeCount : MonoBehaviour{
    public static List<string> nom=new List<string>();
    public static List<int> nbFantome=new List<int>();

    void Start(){
        //Attributions des valeurs pour les différentes listes
        nom.Add("Fantôme(s) Tué");
        nbFantome.Add(0);
        nom.Add("Point Total");
        nbFantome.Add(0);
        nom.Add("Fantôme(s) Total");
        nbFantome.Add(0);
    }

    //La fonction Ajout permet de rajouté 1 au nombre de fantome d'une liste
    public static void Ajout(int element,int ajout){
        nbFantome[element]+=ajout;
    }

    //La fonction Ini permet de réinitialiser une valeur à 0
    public static void Ini(int element){
        nbFantome[element]=0;
    }
}

