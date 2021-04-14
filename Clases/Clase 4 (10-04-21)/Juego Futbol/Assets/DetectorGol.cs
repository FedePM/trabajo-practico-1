using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectorGol : MonoBehaviour
{
    int goles = 0;
    public GameObject jugador;
    void Start(){
        jugador = GameObject.Find("Jugador");
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision) {
        if (collision.gameObject.name == "Pelota"){
            jugador.transform.position = new Vector3(239,5.00001f,482);
            collision.gameObject.transform.position = new Vector3(239,3,496);
            collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            collision.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            goles++;
            Debug.Log("Goles: " + goles.ToString());
        }
    }
}