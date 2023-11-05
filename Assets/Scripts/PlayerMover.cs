using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _jump;
    [SerializeField] private float _shift;
    [SerializeField] public float _speed;
    public Rigidbody rb;
    private float GameTime;
    public bool cubeIsOnTheGround = true;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * _speed;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime * _speed;

        transform.Translate(horizontal, 0f, vertical);
        if(Input.GetKeyDown(KeyCode.Space) && cubeIsOnTheGround)
        {
            rb.AddForce(new Vector3(0f, _jump, 0f), ForceMode.Impulse);
            cubeIsOnTheGround = false;
        }
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            transform.Translate(0f, _shift, 0f);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            transform.Translate(0f, -_shift, 0f);  
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Floor")
        {
            cubeIsOnTheGround = true;
        }
    }  
}