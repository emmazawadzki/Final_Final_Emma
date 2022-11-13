using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampController : MonoBehaviour
{
    private Rigidbody LampeRigidBody;
    [SerializeField] public Transform LampeTransform;

    private void Start() {
        LampeRigidBody = GetComponent<Rigidbody>();
        StartCoroutine(LampeMvt());
    }

    //Mouvement de la lampe sur un angle de 30° en fonction du temps
    private IEnumerator LampeMvt() {
        float timer = 0f;
        while (true) {
            float angle = Mathf.Sin(timer) * 15;
            LampeTransform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
       
            timer += Time.deltaTime;
            yield return null;
        }

    }

}
