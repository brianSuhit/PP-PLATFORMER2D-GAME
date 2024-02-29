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

    /// <summary>
    /// Plays the player jump sound when handling a jump event.
    /// </summary>
    private void HandleJump()
    {
        playerJumpSound.Play();
    }

    /// <summary>
    /// Plays the player collect coin sound when handling a collection event.
    /// </summary>
    private void HandleCollect()
    {
        playerCollectCoinSound.Play();
    }
}
