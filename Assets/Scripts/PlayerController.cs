using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private const string HORIZONTAL_AXIS = "Horizontal";

    [SerializeField]
    private float speed = 5.0f;

    [SerializeField]
    private float turnSpeed;

    [SerializeField]
    private float horizontalInput;

    /// <summary>
    /// Gets or sets a value representing the speed of the player object
    /// </summary>
    public float Speed
    {
        get;
        set;
    }

    /// <summary>
    /// 
    /// </summary>
    public float TurnSpeed
    {
        get;
        set;
    }

    /// <summary>
    /// Gets or sets a value representing the value of the horizontal input
    /// </summary>
    public float HorizontalInput
    {
        get;
        set;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis(HORIZONTAL_AXIS);

        // Move vehicle forward
        this.transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // Sets the vehicle direction based on the turn speed
        //this.transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        print("Poop sticks: " + horizontalInput);
    }
}
