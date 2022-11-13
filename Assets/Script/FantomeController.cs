using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FantomeController : MonoBehaviour
{
    [SerializeField] private GameObject FantomeOriginal;
    [SerializeField] public Transform FantomeTransform;
    [SerializeField] private GameObject Sol;
    [SerializeField] private GameObject Bureau;
    [SerializeField] private GameObject Ch1;
    [SerializeField] private GameObject Ch2;
    [SerializeField] private GameObject Ch3;
    [SerializeField] private GameObject SalleDeBain1;
    [SerializeField] private GameObject SalleDeBain2;
    [SerializeField] private GameObject Salon;
    [SerializeField] private GameObject Cuisine;

    [SerializeField] private TextMeshProUGUI textComponent;

    void Start()
    {
        //Créer un fantome
        CreateFantome();
    }

    void CreateFantome(){
        StartCoroutine(FantomeIni());
    }

    //Initialisation de la position du fantome aléatoirement
    private Vector3 PositionRandomFantome() {
        //Le Fantome se retrouve aléatoirement dans l'une des pièce de la maison      
        int randomNumber = Random.Range(1, 8);
        
        if(randomNumber==1){
            //Le fantome se trouve dans la chambre 1
            textComponent.text = "Tu entends du bruit provenant de la chambre 1";
            return PositionFantome(Ch1);
        }
        else if(randomNumber==2){
            //Le fantome se trouve dans la chambre 2
            textComponent.text = "Tu entends du bruit provenant de la chambre 2";
            return PositionFantome(Ch2);
        }
        else if(randomNumber==3){
            //Le fantome se trouve dans la chambre 3
            textComponent.text = "Tu entends du bruit provenant de la chambre 3";
            return PositionFantome(Ch3);
        }
        else if(randomNumber==4){
            //Le fantome se trouve dans la Salle de bain de la chambre 1
            textComponent.text = "Tu entends du bruit provenant de la Salle de bain 1";
            return PositionFantome(SalleDeBain1);
        }
        else if(randomNumber==5){
            //Le fantome se trouve dans la Salle de bain situé près des 2 autre chambre
            textComponent.text = "Tu entends du bruit provenant de la Salle de bain 2";
            return PositionFantome(SalleDeBain2);
        }
        else if(randomNumber==6){
            //Le fantome se trouve dans le Salon
            textComponent.text = "Tu entends du bruit provenant du Salon";
            return PositionFantome(Salon);
        }
        else if(randomNumber==7){
            //Le fantome se trouve dans la Cuisine
            textComponent.text = "Tu entends du bruit provenant de la Cuisine";
            return PositionFantome(Cuisine);
        }
        else{
            //Le fantome se trouve dans le Bureau
            textComponent.text = "Tu entends du bruit provenant du Bureau";
            return PositionFantome(Bureau);
        }
        
    }
    
    private Vector3 PositionFantome(GameObject nomPiece) {
        //Position aléatoire du Fantome à partir du lieu choisi aléatoirement
        return new Vector3(
            Random.Range(nomPiece.transform.position.x-2,nomPiece.transform.position.x+2),
            FantomeOriginal.transform.position.y,
            Random.Range(nomPiece.transform.position.z-2, nomPiece.transform.position.z+2));
    }

    private IEnumerator FantomeIni() {
        while (true) {
            //Attendre 5 seconde avant de faire apparaître un fantome
            yield return new WaitForSeconds(5f);
            //Faire apparaître un fantome selon la prefab (FantomeOriginal), une position aléatoire et sans rotation
            GameObject fantomeCreation = Instantiate(FantomeOriginal, PositionRandomFantome(), Quaternion.identity);
            FantomeCount.Ajout(2,1);
            //Détruire le fantome au bout de 10 seconde
            Destroy(fantomeCreation,10f);
            
        }
    }

}
