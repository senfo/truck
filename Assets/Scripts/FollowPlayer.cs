using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);

    /// <summary>
    /// Gets or sets a reference to the <see cref="GameObject"/> representing the primary player.
    /// </summary>
    public GameObject Player
    {
        get;
        set;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Locks the cameras position to the main player object with an offset
        transform.position = player.transform.position + offset;
    }
}
