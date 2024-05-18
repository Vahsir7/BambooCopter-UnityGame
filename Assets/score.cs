using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player;
    public TextMesh scoretext;
    // Update is called once per frame
    void Update()
    {
        float playerpos = player.position.x + 12.0f;
        scoretext.text = playerpos.ToString("0");
    }
}
