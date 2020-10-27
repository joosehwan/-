using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Sound
{
    public string soundName;
    public AudioClip clip;  //mp3다
}
public class loadingArmSound : MonoBehaviour
{
    public static loadingArmSound instance;
    
    [Header("사운드 등록")]
    [SerializeField] Sound[] bgmSounds;
    [SerializeField] Sound[] sfxSounds;

    [Header("BGM 플레이어")]
    [SerializeField] AudioSource bgmPlayer;

    [Header("효과음 플레이어")]
    [SerializeField] AudioSource[] sfxPlayer;

    public void PlayBGM()
    {
        bgmPlayer.clip = bgmSounds[0].clip;
        bgmPlayer.Play();
    }
    public void playhorn()
    {
        playSE("shiphorn");
    }

    public void playSE(string _soundName)

    {
        //sfxPlayer.clip = sfxSounds[0].clip;
        //sfxPlayer.Play();
          for (int i = 0; i < sfxSounds.Length; i++)
          {
              if (_soundName == sfxSounds[i].soundName)
              {
                  Debug.Log(sfxSounds[i].soundName);

                  for (int x = 0; x < sfxPlayer.Length; x++)
                  {
                      if (! sfxPlayer[x].isPlaying)
                      {
                          sfxPlayer[x].clip = sfxSounds[i].clip;
                          sfxPlayer[x].Play();
                          return;
                      }
                  }
                //  Debug.Log("모든 효과음 플레이어가 사용중입니다");
                  return;
              }
          }
          Debug.Log("등록된 효과음 없음");
    }
    public void pauseSE(string _soundName)

    {
        //sfxPlayer.clip = sfxSounds[0].clip;
        //sfxPlayer.Play();
        for (int i = 0; i < sfxSounds.Length; i++)
        {
            if (_soundName == sfxSounds[i].soundName)
            {
                //Debug.Log(sfxSounds[i].soundName);

                for (int x = 0; x < sfxPlayer.Length; x++)
                {
                    if (sfxPlayer[x].isPlaying)
                    {
                        sfxPlayer[x].clip = sfxSounds[i].clip;
                        sfxPlayer[x].Pause();
                        return;
                    }
                }
               // Debug.Log("모든 효과음 플레이어가 사용중입니다");
                return;
            }
        }
        Debug.Log("등록된 효과음 없음");
    }


    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        PlayBGM();
        //playSE("machine");
    }


}
