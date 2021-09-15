using UnityEngine;
using Zenject;

public class AudioInstaller : MonoInstaller
{
    [SerializeField] private AudioClip[] _sounds;
    [SerializeField] private AudioHandler _audioHandler;
    public override void InstallBindings()
    {
        Container
            .Bind<AudioHandler>()
            .FromComponentInNewPrefab(_audioHandler)
            .AsSingle();
        Container
            .Bind<AudioClip[]>()
            .FromInstance(_sounds)
            .AsSingle();
    }
}