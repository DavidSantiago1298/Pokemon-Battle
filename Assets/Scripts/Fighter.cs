using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.Events;

public class Fighter : MonoBehaviour
{
    [SerializeField]
    private string  _name;
    public string Name => _name;
    
    [SerializeField]
    private Attacks _attacks;

    [SerializeField]
    private Health _health;

    [SerializeField]
    private Animator _characterAnimator;

    private bool _isActive = false;

    public bool IsActive => _isActive;

    public Health Health => _health;

    public Attacks Attacks => _attacks;

    public Animator CharacterAnimator => _characterAnimator;

    [SerializeField]
    private UnityEvent _onFigtherInitialized;

    [SerializeField]
    private string _winAnimationName = "win";

    public string WinAnimationName => _winAnimationName;

    [SerializeField]
    private string _winSoundName = "winSound";

    public string WinSoundName => _winSoundName;

    public void InitializeFighter()
    {
        _onFigtherInitialized?.Invoke();
    }
}
