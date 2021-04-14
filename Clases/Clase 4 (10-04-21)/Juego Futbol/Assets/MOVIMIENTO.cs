using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVIMIENTO : MonoBehaviour
{

    public float VelX = 10;
    public float VelRot = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Z = Input.GetAxis("Vertical") * Time.deltaTime;
        float X = Input.GetAxis("Horizontal") * Time.deltaTime;

        Vector3 mov = new Vector3(X,0,Z);

        this.transform.Translate(mov * VelX, Space.Self);

        Vector3 rot = new Vector3(0,X,0);

        this.transform.Rotate(rot * VelRot);
    }
}
