using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody PlayerRigidBody;
    [SerializeField] Transform playerCamera = null;
    [SerializeField] float mouseSensitivity = 3f;
    [SerializeField] float vitesse = 7.0f;
    [SerializeField] float gravity = -13.0f;

    float cameraPitch = 0.0f;
    float velocityY=0.0f;
    CharacterController controller = null;

    [SerializeField] Transform viseur;
    //[SerializeField] private GameObject balleArme;
    [SerializeField] private GameObject balleArme;


    void Start(){
        PlayerRigidBody = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
    }

    void Update(){
        if (Input.GetButtonDown("Fire1")){
            TireBalle();
        }
        PlayerCameraDirection();
        PlayerMovement();
    }

    //Tourner la camera en fonction de la souris
    void PlayerCameraDirection(){
        Vector3 directionDelta = new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"),0f);

        cameraPitch -= directionDelta.y * mouseSensitivity;
        cameraPitch = Mathf.Clamp(cameraPitch, -90.0f, 90.0f);

        playerCamera.localEulerAngles = Vector3.right * cameraPitch;
        transform.Rotate(Vector3.up * directionDelta.x * mouseSensitivity);
    }

    //Mouvement du joueur avec les flèche du clavier
    void PlayerMovement(){
        Vector3 inputDir = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"),0f);
        inputDir.Normalize();
		
        if(controller.isGrounded){
            velocityY=0.0f;
        }

        velocityY+=gravity*Time.deltaTime;

        Vector3 velocity = (transform.forward * inputDir.y + transform.right * inputDir.x) * vitesse;
        velocity += Vector3.up*velocityY;
        controller.Move(velocity * Time.deltaTime);

    }

    private void TireBalle()
    {
        //J'instantie la balle
        GameObject balle=Instantiate(balleArme,viseur.position,Quaternion.identity);

        //Je récupère son rigidbody
        Rigidbody balleRigidBody=balle.GetComponent<Rigidbody>();

        //J'applique une force initiale à la balle
        //*1500f pour avoir une grande impulsion
        balleRigidBody.AddForce(viseur.forward*1500f);
    }
}
