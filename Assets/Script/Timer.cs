using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private float valeurTemps = 90;
    [SerializeField] private TextMeshProUGUI textComponent;
    
    void Update(){
        if(valeurTemps>0){
            valeurTemps -= Time.deltaTime;
        }
        else{
            valeurTemps =0;
            //Si le timer est fini, on charge la dernière scène (Partie Finie)
            SceneManager.LoadScene(2);
        }
        AfficherTemps(valeurTemps);
    }

    //Permet d'Afficher le temps en format 0:00 (minutes:secondes)
    void AfficherTemps(float afficheTemps){
        if(afficheTemps<0){
            afficheTemps = 0;
        }
        float minutes = Mathf.FloorToInt(afficheTemps / 60);
        float secondes = Mathf.FloorToInt(afficheTemps % 60);

        textComponent.text = string.Format("{0:00}:{1:00}",minutes,secondes);
    }
}
