using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class GestionnaireAudio : MonoBehaviour
{
  
    [SerializeField]
    private AudioMixer audioMixer;

    [SerializeField]
    private Slider glissiereVolumeMusique;

    [SerializeField]
    private Slider glissiereVolumeFX;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void AjusteVolumeMusique(float volume){
        audioMixer.SetFloat("VolumeMusique", ConvertToLogarithmique(volume));
    }

    public void AjusteVolumeEffets(float volume){
        audioMixer.SetFloat("VolumeEffets", ConvertToLogarithmique(volume));
        audioMixer.SetFloat("VolumeDiscussion", ConvertToLogarithmique(volume));
    }

    private float ConvertToLogarithmique(float volume)
    {
        return Mathf.Log10(volume) * 20;
    }
}
