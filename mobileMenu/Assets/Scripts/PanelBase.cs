using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public abstract class PanelBase : MonoBehaviour, IPanel
{
    protected abstract string ID{get;}

    private CanvasGroup _canvasGroup;
    private CanvasGroup CanvasGroup{get {return _canvasGroup==null ? _canvasGroup = GetComponent<CanvasGroup>() : _canvasGroup ;}}

    public virtual void showPanel()
    {
        CanvasGroup.alpha=1;
        CanvasGroup.blocksRaycasts= true;
        CanvasGroup.interactable= true;
    }

    public virtual void hidePanel()
    {
        CanvasGroup.alpha=0;
        CanvasGroup.blocksRaycasts= false;
        CanvasGroup.interactable= false;
    }
}
