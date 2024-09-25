using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ImageTargetHandler : MonoBehaviour
{   
    private ObserverBehaviour mObserverBehaviour;

    void Start()
    {
        mObserverBehaviour = GetComponent<ObserverBehaviour>();

        //EVENT SUBSCRIPTION 
        if (mObserverBehaviour) mObserverBehaviour.OnTargetStatusChanged += OnTargetStatusChanged;
    }

    private void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus status)
    {
        if (status.Status == Status.TRACKED) OnTrackingFound();

        else OnTrackingLost();
    }

    private void OnTrackingFound()
    {
        foreach (Transform child in transform) child.gameObject.SetActive(true);
    }

    private void OnTrackingLost()
    {
        foreach (Transform child in transform) child.gameObject.SetActive(false);
    }

    void OnDestroy()
    {
        //EVENT UNSUBSCRIPTION
        if (mObserverBehaviour) mObserverBehaviour.OnTargetStatusChanged -= OnTargetStatusChanged;
    }
}