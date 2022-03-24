using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.UI;

public class Playgameservices : MonoBehaviour
{
    [SerializeField] Text debugtext;
    void Start()
    {
        Initialize();
    }
    void Initialize()
    {
        PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder()
        .RequestServerAuthCode(false)
        .Build();
        PlayGamesPlatform.InitializeInstance(config);
        PlayGamesPlatform.Activate();
        debugtext.text = "playgames initialized";
        SignInUserWithPlaygame();
    }

    void SignInUserWithPlaygame ()
    {
        PlayGamesPlatform.Instance.Authenticate(SignInInteractivity.CanPromptOnce, (success)=> 
        {
            switch(success)
            {
                case SignInStatus.Success:
                debugtext.text = "Signin player using play games successful";
                break;
                default:
                debugtext.text = "Signin not successful";
                break;
            }
        });
    }

    public void AchievementCompleted()
    {
        Social.ReportProgress("CgkIxMDE3NMREAIQAA", 100.0f,(bool success) => 
        {
            if(success)
            {
                debugtext.text = "Achievement successfully unlocked";
            }
            else 
            {
                debugtext.text = "not successful";
            }
        });

    }

    public void ShowAchievement()
    {
        Social.ShowAchievementsUI();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
