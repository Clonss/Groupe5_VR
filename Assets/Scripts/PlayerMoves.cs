using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(SteamVR_TrackedController))]
public class PlayerMoves : MonoBehaviour
{

    public Transform pointerObj;
    private NavMeshAgent myNMA;

    [SerializeField]

    private SteamVR_TrackedController trackedController;

    // Start is called before the first frame update
    void Start()
    {
        myNMA = GetComponent<NavMeshAgent>();
        trackedController = GetComponent<SteamVR_TrackedController>();
        trackedController.PadClicked += Walk;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Walk(object sender, ClickedEventArgs e)
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);


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
