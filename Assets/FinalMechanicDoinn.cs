using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class FinalMechanicDoinn : CanBeTriggeredByPlayer
{

    private DialogueInvoker di;
    void Start()
    {
        di = GetComponent<DialogueInvoker>();
    }

    void Update()
    {
        if (di.stage == 1 && isPlayer && Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(Do());
        }
    }

    private IEnumerator Do()
    {
        yield return new WaitForSeconds(10f);
        foreach (var VARIABLE in FindObjectsOfType<DialogueScreen>())
        {
            Destroy(VARIABLE.gameObject);
        }
        GlobalVars.i.DoneTech();
    }
}
