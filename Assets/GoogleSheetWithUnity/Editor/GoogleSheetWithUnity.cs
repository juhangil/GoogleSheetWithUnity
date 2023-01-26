using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class GoogleSheetWithUnity : EditorWindow
{
    [SerializeField]
    private VisualTreeAsset m_VisualTreeAsset = default;

    [MenuItem("Cockatoo/Google Sheet With Unity")]
    public static void ShowExample()
    {
        GoogleSheetWithUnity wnd = GetWindow<GoogleSheetWithUnity>();
        wnd.titleContent = new GUIContent("GoogleSheetWithUnity");
    }

    public void CreateGUI()
    {
        // Each editor window contains a root VisualElement object
        VisualElement root = rootVisualElement;

        // VisualElements objects can contain other VisualElement following a tree hierarchy.
        VisualElement label = new Label("Hello World! From C#");
        root.Add(label);

        // Instantiate UXML
        VisualElement labelFromUXML = m_VisualTreeAsset.Instantiate();
        root.Add(labelFromUXML);
    }
}
