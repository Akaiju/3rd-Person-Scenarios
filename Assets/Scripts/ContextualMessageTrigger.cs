﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContextualMessageTrigger : MonoBehaviour
{
    [SerializeField]
    [TextArea (3,6)]
    private string message = "Default message";

    [SerializeField]
    private float messageDuration = 1.0f;

    public static event Action<string, float> ContextualMessageTriggered;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (ContextualMessageTriggered != null)
            {
                ContextualMessageTriggered.Invoke(message, messageDuration);
            }
        }
    }
}
