using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public void RecocommencerPartie()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
