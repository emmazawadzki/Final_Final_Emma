using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalleController : MonoBehaviour
{   
    public FantomePoint fantomePoint1;
    public FantomePoint fantomePoint2;
    public FantomePoint fantomePoint3;

    public void OnCollisionEnter(Collision collision){

        //Si la balle touche un élément du décors, la balle est détruite
        if (collision.gameObject.layer==LayerMask.NameToLayer("Decors")){
            Destroy(gameObject);
        }

        //Si la balle touche un fantome, le fantome et la balle sont détruits
        else if (collision.gameObject.layer==LayerMask.NameToLayer("Fantome")){
            int point=Random.Range(1, 3);
            if(point==1){
                //Le fantome tué vaut 1 point
                FantomeCount.Ajout(1,fantomePoint1.point);
            }
            else if(point==2){
                //Le fantome tué vaut 2 points
                FantomeCount.Ajout(1,fantomePoint2.point);
            }
            else{
                //Le fantome tué vaut 3 points
                FantomeCount.Ajout(1,fantomePoint3.point);
            }
            Destroy(collision.gameObject);
            //On ajoute 1 au nombre total de fantome tué
            FantomeCount.Ajout(0,1);
            Destroy(gameObject);
        }
            
    }

}
