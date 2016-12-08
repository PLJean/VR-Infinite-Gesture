﻿using UnityEngine;
using UnityEditor;
using System.Collections;

namespace Edwon.VR.Gesture
{
    [ExecuteInEditMode]
    public class TutorialUI : MonoBehaviour
    {

        TutorialUIPanelManager panelManager;

        public int currentTutorialStep = 1;

        void Start()
        {
            panelManager = GetComponentInChildren<TutorialUIPanelManager>();

            StartCoroutine(IETutorialSequence());
        }

        IEnumerator IETutorialSequence()
        {
            panelManager.FocusPanel(2.ToString());

            yield break;
        }


        #region EVENTS

        void OnEnable()
        {
            PanelManager.OnPanelFocusChanged += PanelFocusChanged;
        }

        void OnDisable()
        {
            PanelManager.OnPanelFocusChanged -= PanelFocusChanged;
        }

        void PanelFocusChanged(Panel panel)
        {
            
        }

        #endregion
    }
}