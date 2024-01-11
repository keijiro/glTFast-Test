using UnityEngine;
using UnityEngine.UI;
using GLTFast;

public sealed class RuntimeImporter : MonoBehaviour
{
    [field:SerializeField] public GltfAsset Root { get; set; } = null;
    [field:SerializeField] public InputField UrlField { get; set; } = null;

    public void ImportScene()
    {
        Root.ClearScenes();
        Root.Load(UrlField.text);
    }
}
