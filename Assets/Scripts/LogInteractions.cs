using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LogInteractions : MonoBehaviour
{
  // First/Last Hover
  public void LogFirstHoverEnter(HoverEnterEventArgs args)
  {
    Debug.Log(gameObject.name + "Hover Enter by: " + args.interactorObject);
  }

  public void LogLastHoverExit(HoverExitEventArgs args)
  {
    Debug.Log(gameObject.name + "Hover Enter by: " + args.interactorObject);
  }

  // Hover
  public void LogHoverEnter(HoverEnterEventArgs args)
  {
    Debug.Log(gameObject.name + "Hover Enter by: " + args.interactorObject);
  }

  public void LogHoverExit(HoverExitEventArgs args)
  {
    Debug.Log(gameObject.name + "Hover Enter by: " + args.interactorObject);
  }

  // First/Last Select
  public void LogFirstSelectEnter(SelectEnterEventArgs args)
  {
    Debug.Log(gameObject.name + "Hover Enter by: " + args.interactorObject);
  }

  public void LogLastSelectEnter(SelectExitEventArgs args)
  {
    Debug.Log(gameObject.name + "Hover Enter by: " + args.interactorObject);
  }

  // Select
  public void LogSelectEnter(SelectEnterEventArgs args)
  {
    Debug.Log(gameObject.name + "Hover Enter by: " + args.interactorObject);
  }

  public void LogSelectExit(SelectExitEventArgs args)
  {
    Debug.Log(gameObject.name + "Hover Enter by: " + args.interactorObject);
  }

  // Active
  public void LogActivated(ActivateEventArgs args)
  {
    Debug.Log(gameObject.name + "Hover Enter by: " + args.interactorObject);
  }

  public void LogDeactivated(DeactivateEventArgs args)
  {
    Debug.Log(gameObject.name + "Hover Enter by: " + args.interactorObject);
  }
}
