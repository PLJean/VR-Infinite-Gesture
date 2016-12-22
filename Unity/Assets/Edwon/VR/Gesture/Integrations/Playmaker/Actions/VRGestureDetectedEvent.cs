#if PLAYMAKER

using UnityEngine;
using Edwon.VR.Gesture;
using Edwon.VR;

namespace HutongGames.PlayMaker.Actions
{

    [ActionCategory("VRGestureTracker")]
    [Tooltip ("Listens for gestures detected with the Edwon VR Gesture Tracker plugin")]
    public class VRGestureDetectedEvent : FsmStateAction
    {
        public FsmString gestureName;
        public FsmEvent gestureDetectedEvent;

        // Code that runs on entering the state.
        public override void OnEnter()
	    {
            GestureRecognizer.GestureDetectedEvent += OnGestureDetected;
        }

	    // Code that runs when exiting the state.
	    public override void OnExit()
	    {
            GestureRecognizer.GestureDetectedEvent -= OnGestureDetected;
        }

        void OnGestureDetected (string _gestureName, double _confidence, Handedness _hand, bool isDouble)
        {
            if (_gestureName == gestureName.Value)
            {
                Fsm.Event(gestureDetectedEvent);
            }
        }
    }

}

#endif