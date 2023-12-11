using UnityEditor;
using UnityEngine;

[CustomEditor (typeof(PanelBase), true) ]
public class PanelEditor : UnityEditor.Editor
{
    private PanelBase panel;

    private void OnEnable()
    {
        panel = (PanelBase)target;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (GUILayout.Button("showPanel"))
        {
            panel.showPanel();
        }
        if (GUILayout.Button("HidePanel"))
        {
            panel.hidePanel();
        }
    }
}
