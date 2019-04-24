using System.Collections;
using UnityEngine;

[RequireComponent(typeof(SteamVR_TrackedController))]
public class DashController : MonoBehaviour
{
    [SerializeField]
    private float minDashRange = 0.5f;
    [SerializeField]
    private float maxDashRange = 40f;

    [SerializeField]

    private SteamVR_TrackedController trackedController;
    private Transform cameraRigRoot;

    private void Start()
    {
        cameraRigRoot = transform.parent;

        trackedController = GetComponent<SteamVR_TrackedController>();
        trackedController.PadClicked += Walk;
    }

    private void Walk(object sender, ClickedEventArgs e)
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.distance > minDashRange && hit.distance < maxDashRange)
            {
                StartCoroutine(DoWalk(hit.point));
            }
        }
    }


    private IEnumerator DoWalk(Vector3 endPoint)
    {
        yield return new WaitForSeconds(0.1f);

        Vector3 startPoint = cameraRigRoot.position;
    }
}
