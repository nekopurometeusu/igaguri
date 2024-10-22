using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera MainCamera;
    public Camera EffectCamera;
    //�ω������鎞��
    public float transitionDuration = 2.0f;
    //�J�����̏����ʒu
    public Vector3 startPosition = new Vector3(0, 6, -5);
    //�J�����̏I���ʒu
    public Vector3 endPosition = new Vector3(0, 5, -9);

   
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CameraTransition());

    }
    private IEnumerator CameraTransition()
    {
        MainCamera.enabled = false;
        EffectCamera.enabled = true;

        EffectCamera.transform.position = startPosition;

        float elapsedtime = 0f;
        while(elapsedtime < transitionDuration)
        {
            EffectCamera.transform.position = Vector3.Lerp(startPosition, endPosition, elapsedtime / transitionDuration);
            elapsedtime += Time.deltaTime;
            yield return null;
        }
        //�J�����ɃI�u�W�F�N�g������
        MainCamera.enabled = true;
        EffectCamera.enabled = false;
      
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
