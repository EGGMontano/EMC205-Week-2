using UnityEngine;

public class Collision : MonoBehaviour
{

    [Header("Audio")]
    [Tooltip("Drag sound file here")]
    [SerializeField] private AudioClip audioClip;
    [Tooltip("Where the sound will come from (drag game object)")]
    [SerializeField] private AudioSource audioSource;

    [Header("Effects")]
    [Tooltip("Particle System from asset store")]
    [SerializeField] private ParticleSystem particleSys;

    [Header("Collision")]
    [SerializeField] LayerMask wallLayer;


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
