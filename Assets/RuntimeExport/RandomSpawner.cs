using UnityEngine;

public sealed class RandomSpawner : MonoBehaviour
{
    [field:SerializeField] public GameObject Prefab { get; set; } = null;
    [field:SerializeField] public Transform Root { get; set; } = null;
    [field:SerializeField] public float Interval { get; set; } = 0.2f;
    [field:SerializeField] public float InstanceLife { get; set; } = 5;

    async void KillInstance(GameObject instance, float delay)
    {
        await Awaitable.WaitForSecondsAsync(delay);
        Destroy(instance);
    }

    async void Start()
    {
        while (true)
        {
            await Awaitable.WaitForSecondsAsync(Interval);
            var displace = new Vector3(Random.Range(-1.0f, 1.0f), 0, Random.Range(-1.0f, 1.0f));
            var instance = Instantiate(Prefab, transform.position + displace, Quaternion.identity, Root);
            KillInstance(instance, InstanceLife);
        }
    }
}
