using UnityEngine;

public class BallManager : MonoBehaviour
{
    [Header("碰到畫布後的圖示或顏料")]
    public GameObject pictureObject;
    [Header("碰到畫布後的特效")]
    public GameObject effectObject;
    [Header("碰撞音效")]
    public AudioClip soundHit;
}
