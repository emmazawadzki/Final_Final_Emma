using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CibleMouvement : MonoBehaviour
{
    private Rigidbody FantomeRigidBody;
    [SerializeField] public Transform CibleTransform;

    private void Start() {
        FantomeRigidBody = GetComponent<Rigidbody>();
        StartCoroutine(CibleMvt());
    }

    private IEnumerator CibleMvt() {
        //La cible attend 1 secondes avant de commencer à bouger
        yield return new WaitForSeconds(1f);

        //Mouvement de la cible
        while (true) {
            float DurerMouvement = Random.Range(1f, 3f);
            float Timer = 0f;

            //Changement de la position
            Vector3 deltaPosition = new Vector3(
                Random.Range(-1f, 1f),
                0f,
                Random.Range(-1f, 1f))*Time.deltaTime*1f;

            //Temps que le timer est inférieur à la durée du mouvement, on augmente le timer et la position
            while (DurerMouvement > Timer) {
                Timer += Time.deltaTime;
                CibleTransform.position += deltaPosition;
                yield return new WaitForEndOfFrame();
            }
        }
    }

}
