using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _Jump;
    public MeshRenderer MeshRenderer;
    private float GameTime;
    public static CursorLockMode lockState;
    public float maxJumpAcrossDistance;
    public Rigidbody rb;
    public float gravityScale = 5;
    

    private void Update()
    {
        Rigidbody.AddForce(Vector3 force);
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 0f, 0.01f);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 0f, -0.01f);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.01f, 0f, 0f);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.01f, 0f, 0f);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
              
        }
    }
    private void FixedUpdate()
    {
        
        rb.AddForce(Physics.gravity * (gravityScale - 1) * rb.mass);
    }   
    public void OnGui()
    {
        if (GUI.Button(new Rect(0, 0, 100, 50), "Lock Cursor"))
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}