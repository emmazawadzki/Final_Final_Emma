using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonRetourAcceuil : MonoBehaviour
{   
    public void GoToMenu(){
        SceneManager.LoadScene(0);
        //On remet les valeurs à 0 pour la prochaine partie
        FantomeCount.Ini(0);
        FantomeCount.Ini(1);
        FantomeCount.Ini(2);
    }

}
