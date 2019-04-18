using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMoves : MonoBehaviour
{

    public Transform pointerObj;
    private NavMeshAgent myNMA;

    // Start is called before the first frame update
    void Start()
    {
        myNMA = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 5f))
        {
            pointerObj.position = hit.point;
            if (Input.GetMouseButtonDown(0))
            {
                myNMA.destination = hit.point;
            }
        }
    }
}
