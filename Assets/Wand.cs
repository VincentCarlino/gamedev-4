using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wand : MonoBehaviour
{
    public float range = 100f;
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot("fly");
        }
        if (Input.GetMouseButtonDown(1))
        {
            Shoot("fall");
        }
    }

    void Shoot(string command)
    {
        RaycastHit hit;
        if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, range))
        {
            if(command == "fly")
            {
                hit.transform.GetComponent<Levitate>().SetFly(true);
            }
            else if (command == "fall")
            {
                hit.transform.GetComponent<Levitate>().SetFly(false);
            }
            
        };
    }

    
}
