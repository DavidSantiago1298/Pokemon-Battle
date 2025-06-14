using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Fighter : MonoBehaviour
{
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
}
