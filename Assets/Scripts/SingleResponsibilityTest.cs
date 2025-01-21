using UnityEngine;

public class SingleResponsibilityTest : MonoBehaviour
{
    //[Header("Movement")]
    //[Tooltip("Horizontal Speed")]
    //[SerializeField] private float moveSpeed;
    //[Tooltip("Rate of change for moveSpeed")]
    //[SerializeField] private float accelerationMoveSpeed;
    //[Tooltip("Deceleration rate when no input is provided")]
    //[SerializeField] private float decelerationMoveSpeed;

    //[Header("Controls")]
    //[Tooltip("Use keys to move")]
    //[SerializeField] private KeyCode forwardKey;
    //[SerializeField] private KeyCode backwardKey;
    //[SerializeField] private KeyCode leftKey;
    //[SerializeField] private KeyCode rightKey;

    [Header("Audio")]
    [SerializeField] private AudioClip audioClip;
    [SerializeField] private AudioSource audioSource;

    [Header("Effects")]
    [SerializeField] private ParticleSystem particleSys;

    [Header("Collision")]
    [SerializeField] LayerMask wallLayer;

    //private Vector3 inputVector;
    //private float currentSpeed;
    //private CharacterController characterController;
    //private float initialYPosition;

    //private void Awake()
    //{
    //    characterController = GetComponent<CharacterController>();
    //    initialYPosition = transform.position.y;
    //}

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    //void Update()
    //{
    //    HandleInput();
    //    Move(inputVector);
    //}

    //private void HandleInput()
    //{
    //    float xInput = 0;
    //    float zInput = 0;

    //    if (Input.GetKey(forwardKey))
    //    {
    //        zInput++;
    //    }

    //    if (Input.GetKey(backwardKey))
    //    {
    //        zInput--;
    //    }

    //    if (Input.GetKey(leftKey))
    //    {
    //        xInput--;
    //    }

    //    if (Input.GetKey(rightKey))
    //    {
    //        xInput++;
    //    }

    //    inputVector = new Vector3 (xInput, 0, zInput);
    //}

    //private void Move(Vector3 inputVector)
    //{
    //    if (inputVector == Vector3.zero)
    //    {
    //        if (currentSpeed > 0)
    //        {
    //            currentSpeed -= decelerationMoveSpeed * Time.deltaTime;
    //            currentSpeed = Mathf.Max(currentSpeed, 0);
    //        }
    //    }
    //    else
    //    {
    //        currentSpeed =Mathf.Lerp(currentSpeed, moveSpeed, Time.deltaTime * accelerationMoveSpeed);
    //    }

    //    Vector3 movement = inputVector.normalized * currentSpeed * Time.deltaTime;
    //    characterController.Move(movement);
    //    transform.position = new Vector3 (transform.position.x, initialYPosition, transform.position.z);
    //}

    private void PlayAudioClip()
    {
        audioSource.Play();
    }

    private void PlayParticleEffect()
    {
        particleSys.Play();
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if ((wallLayer.value & (1 << hit.gameObject.layer)) > 0)
        {
            PlayAudioClip();
            PlayParticleEffect();
        }
    }
}
