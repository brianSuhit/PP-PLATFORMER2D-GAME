using UnityEngine;

public class CharacterAudio : MonoBehaviour
{
    [SerializeField] private AudioSource playerJumpSound;
    [SerializeField] private AudioSource playerCollectCoinSound;

    [SerializeField] private CharacterJump jump;
    [SerializeField] private CoinCollect coin;

    private void OnEnable()
    {
        if (jump)
        {
            jump.onJump += HandleJump;
        }

        if (coin)
        {
            coin.onCollect += HandleCollect;
        }
    }

    private void OnDisable()
    {
        if (jump)
        {
            jump.onJump -= HandleJump;
        }

        if (coin)
        {
            coin.onCollect -= HandleCollect;
        }
    }

    private void HandleJump()
    {
        playerJumpSound.Play();
    }

    private void HandleCollect()
    {
        playerCollectCoinSound.Play();
    }
}
