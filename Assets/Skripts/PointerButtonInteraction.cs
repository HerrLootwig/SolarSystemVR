using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static OVRHand;

public class PointerButtonInteraction : MonoBehaviour
{
    public OVRHand hand;
    void Awake(){

        hand = GetComponent<OVRHand>();


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isIndexFingerPinching = hand.GetFingerIsPinching(HandFinger.Index);
        TrackingConfidence confidence = hand.GetFingerConfidence(HandFinger.Index);
        var indexFingerPinchStrength = hand.GetFingerPinchStrength(HandFinger.Index);

        Debug.Log(isIndexFingerPinching); 
        Debug.Log(indexFingerPinchStrength);
    }
}
