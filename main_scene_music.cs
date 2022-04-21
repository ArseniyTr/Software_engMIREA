using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_scene_music : MonoBehaviour
{
    public AudioClip musicAudioClip;

    // �������� ��� ������������ ������
    private AudioSource _musicAudioSource = null;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        _musicAudioSource = gameObject.AddComponent<AudioSource>();
        _musicAudioSource.PlayOneShot(musicAudioClip);
    }

}
