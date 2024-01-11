using UnityEngine;
using UnityEngine.UI;
using GLTFast.Export;

public sealed class RuntimeExporter : MonoBehaviour
{
    [field:SerializeField] public Transform Root { get; set; } = null;
    [field:SerializeField] public InputField PathField { get; set; } = null;

    public void ExportScene()
    {
        var path = "Export/Test.gltf";
        var export = new GameObjectExport();
        export.AddScene(new[]{Root.gameObject});
        export.SaveToFileAndDispose(PathField.text);
    }
}
