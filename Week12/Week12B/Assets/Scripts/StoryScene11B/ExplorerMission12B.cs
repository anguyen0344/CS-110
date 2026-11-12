using UnityEngine;
using UnityEngine.SceneManagement;

public sealed class ExplorerMission12B : MonoBehaviour
{
    private StoryBeacon beacon;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Register()
    {
        SceneManager.sceneLoaded -= SetUp;
        SceneManager.sceneLoaded += SetUp;
    }

    private static void SetUp(Scene scene, LoadSceneMode mode)
    {
        if (scene.name != "ExplorerBeacon12B") return;
        var mission = new GameObject("Mission HUD").AddComponent<ExplorerMission12B>();
        mission.beacon = GameObject.Find("Beacon")?.GetComponent<StoryBeacon>();
        var explorer = GameObject.Find("Explorer");
        if (explorer != null && Spawn("ExplorerShell", explorer.transform, new Color(.18f,.64f,.82f)) != null)
        {
            var old = explorer.GetComponent<MeshRenderer>();
            if (old != null) old.enabled = false;
        }
        var outpost = Spawn("Outpost", null, new Color(.26f,.34f,.38f));
        if (outpost != null)
            foreach (var filter in outpost.GetComponentsInChildren<MeshFilter>())
                if (filter.sharedMesh != null)
                    filter.gameObject.AddComponent<MeshCollider>().sharedMesh = filter.sharedMesh;
    }

    private static GameObject Spawn(string name, Transform parent, Color color)
    {
        var model = Resources.Load<GameObject>("ExplorerBeacon12B/" + name);
        if (model == null)
        {
            Debug.LogError("Missing imported model: " + name);
            return null;
        }
        var instance = Instantiate(model, parent, false);
        instance.name = name;
        var appearance = new MaterialPropertyBlock();
        appearance.SetColor("_BaseColor", color);
        appearance.SetColor("_Color", color);
        foreach (var renderer in instance.GetComponentsInChildren<MeshRenderer>())
            renderer.SetPropertyBlock(appearance);
        return instance;
    }

    private void OnGUI()
    {
        bool activated = beacon != null && beacon.IsActivated;
        var bounds = new Rect(12, 12, Mathf.Max(1, Mathf.Min(580, Screen.width - 24)), 64);
        GUI.Box(bounds, GUIContent.none);
        var style = new GUIStyle(GUI.skin.label) { fontSize = 16, wordWrap = true };
        var text = activated ? "Communication restored" :
            "Explorer Beacon\nMove: WASD or arrows. Walk to the beacon and press E.";
        GUI.Label(new Rect(22, 18, Mathf.Max(1, bounds.width - 20), 54), text, style);
    }
}
